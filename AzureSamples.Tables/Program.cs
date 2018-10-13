using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureSamples.Tables
{
    internal class Program
    {
        private const string ConnectionString = "[Your Connection String Here]";

        internal static void Main(string[] args)
        {
            try
            {
                ////InsertOperationAsync()
                ////RetrieveOperationAsync()
                ////QueryAsync()
                OperationsInTransactionAsync()
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadKey();
        }

        private static async Task<CloudTable> GetTableReference()
        {
            var storageConnection = CloudStorageAccount.Parse(ConnectionString);
            var tableClient = storageConnection.CreateCloudTableClient();

            var table = tableClient.GetTableReference("Products");
            await table.CreateIfNotExistsAsync();
            return table;
        }

        private static async Task InsertBatchOperationAsync()
        {
            var table = await GetTableReference();

            var product = Products.AllProducts.First();
            var insertOperation = TableOperation.Insert(product);
            await table.ExecuteAsync(insertOperation);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Inserted: {product}");
        }

        private static async Task InsertOperationAsync()
        {
            var table = await GetTableReference();

            var product = Products.AllProducts.First();

            var insertOperation = TableOperation.Insert(product);
            await table.ExecuteAsync(insertOperation);
        }

        private static async Task<(string, string)> InsertOrReplaceAsync()
        {
            var product = Products.AllProducts.First();
            await InsertOrReplaceAsync(product);

            return (product.PartitionKey, product.RowKey);
        }

        private static async Task<(string, string)> InsertOrReplaceAsync(ProductEntity product)
        {
            var table = await GetTableReference();

            var insertOperation = TableOperation.InsertOrReplace(product);
            await table.ExecuteAsync(insertOperation);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Inserted / Replaced: {product}");

            return (product.PartitionKey, product.RowKey);
        }

        private static async Task OperationsInTransactionAsync()
        {
            var table = await GetTableReference();

            var batchOperation = new TableBatchOperation();
            var firstProduct = Products.AllProducts.First();
            foreach (var product in Products.AllProducts.Where(x => x.PartitionKey == firstProduct.PartitionKey))
            {
                batchOperation.InsertOrReplace(product);
            }

            await table.ExecuteBatchAsync(batchOperation);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Inserted in batch!");
        }

        private static async Task QueryAsync()
        {
            var table = await GetTableReference();

            foreach (var product in Products.AllProducts.Take(20))
            {
                await InsertOrReplaceAsync(product);
            }

            var items = new List<ProductEntity>();
            TableContinuationToken token = null;
            var query = new TableQuery<ProductEntity>();

            do
            {
                var segment = await table.ExecuteQuerySegmentedAsync<ProductEntity>(query, token);
                token = segment.ContinuationToken;
                items.AddRange(segment);
            } while (token != null);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Query Result");

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static async Task RetrieveOperationAsync()
        {
            var table = await GetTableReference();

            var (partitionKey, rowKey) = await InsertOrReplaceAsync();

            var operation = TableOperation.Retrieve<ProductEntity>(partitionKey, rowKey);
            var response = await table.ExecuteAsync(operation);

            if (response.Result == null)
            {
                Console.WriteLine("Product not found");
            }
            else
            {
                Console.WriteLine("Product found!");
                Console.WriteLine(((ProductEntity)response.Result).ToString());
            }
        }
    }
}
