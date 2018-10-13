using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AzureSamples.Blobs
{
    internal class Program
    {
        private const string ConnectionString = "[Storage Account Connection String]";
        private const string ContainerName = "[Container Name e.g. documents]";

        internal static void Main(string[] args)
        {
            try
            {
                ////UploadBlockBlobFromFileAsync()
                ////UploadBlockBlobFromStreamAsync()
                ////UploadBlockBlobToDirectoryAsync()
                DownloadBlobToFileAsync()
                ////PrintContainerMetadataAsync()
                ////SetContainerMetadataAsync()
                ////PrintContainerMetadataAsync()
                ////CopyBlobAsync()
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static async Task CopyBlobAsync()
        {
            var blob = await UploadBlockBlobFromFileAsync();

            var copyContainer = await GetBlobContainerReference($"{ContainerName}-copy");

            var copyBlob = copyContainer.GetBlockBlobReference(GetFilename());

            await copyBlob.StartCopyAsync(blob);
        }

        private static void CreateHelloWorldFile(out string filepath, out string filename)
        {
            filename = GetFilename();
            filepath = GetFilepath(filename);

            File.WriteAllText(filepath, "Hello, World!");
        }

        private static async Task DownloadBlobToFileAsync()
        {
            var container = await GetBlobContainerReference();

            CreateHelloWorldFile(out string filepath, out string filename);

            var blockBlob = container.GetBlockBlobReference(filename);

            await blockBlob.UploadFromFileAsync(filepath);

            await blockBlob.DownloadToFileAsync(GetFilepath("Downloaded File.txt"), FileMode.OpenOrCreate);
        }

        private static async Task<CloudBlobContainer> GetBlobContainerReference()
        {
            return await GetBlobContainerReference(ContainerName);
        }

        private static async Task<CloudBlobContainer> GetBlobContainerReference(string containerName)
        {
            // Get reference to Cloud Storage Account
            var storageAccount = CloudStorageAccount.Parse(ConnectionString);

            // Create Cloud Blob Client instance
            var blobClient = storageAccount.CreateCloudBlobClient();

            // Get Cloud Blob Container reference
            var container = blobClient.GetContainerReference(containerName);

            // Create the container if not exist
            await container.CreateIfNotExistsAsync();

            return container;
        }

        private static string GetFilename()
        {
            return $"HelloWorld_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
        }

        private static string GetFilepath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filename);
        }

        private static async Task PrintContainerMetadataAsync()
        {
            var container = await GetBlobContainerReference();

            await container.FetchAttributesAsync();

            foreach (var metadata in container.Metadata)
            {
                Console.WriteLine($"{metadata.Key}: {metadata.Value}");
            }
        }

        private static async Task PrintContainerPropertiesAsync()
        {
            var container = await GetBlobContainerReference();

            Console.WriteLine($"Container Primary URI: {container.StorageUri.PrimaryUri}");

            await container.FetchAttributesAsync();

            Console.WriteLine($"Last modified date: {container.Properties.LastModified}");
            Console.WriteLine($"Public access: {container.Properties.PublicAccess}");
            Console.WriteLine($"ETag: {container.Properties.ETag}");
        }

        private static async Task SetContainerMetadataAsync()
        {
            var container = await GetBlobContainerReference();

            ////container.Metadata.Clear();
            container.Metadata.Add("Region", "United Arab Emirates");
            container.Metadata["Location"] = "Head Office";
            await container.SetMetadataAsync();
        }

        private static async Task<CloudBlockBlob> UploadBlockBlobFromFileAsync()
        {
            var container = await GetBlobContainerReference();

            CreateHelloWorldFile(out string filepath, out string filename);

            var blockBlob = container.GetBlockBlobReference(filename);

            await blockBlob.UploadFromFileAsync(filepath);

            return blockBlob;
        }

        private static async Task UploadBlockBlobFromStreamAsync()
        {
            var container = await GetBlobContainerReference();

            CreateHelloWorldFile(out string filepath, out string filename);

            var blockBlob = container.GetBlockBlobReference(filename);

            using (var stream = File.OpenRead(filepath))
            {
                await blockBlob.UploadFromStreamAsync(stream);
            }
        }

        private static async Task UploadBlockBlobToDirectoryAsync()
        {
            var container = await GetBlobContainerReference();

            CreateHelloWorldFile(out string filepath, out string filename);

            var parentDirectory = container.GetDirectoryReference("all-samples");
            var subDirectory = parentDirectory.GetDirectoryReference("sub-directory");
            var blockBlob = subDirectory.GetBlockBlobReference(filename);

            await blockBlob.UploadFromFileAsync(filepath);
        }
    }
}
