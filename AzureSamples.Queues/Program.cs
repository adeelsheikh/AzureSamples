using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Threading.Tasks;

namespace AzureSamples.Queues
{
    internal class Program
    {
        private const string ConnectionString = "[Your Connection String Here]";

        internal static void Main(string[] args)
        {
            AddMessagesAsync()
            ////GetMessagesAsync()
            ////PeekMessagesAsync()
            ////DeleteQueueAsync()
                .GetAwaiter().GetResult();
        }

        private static async Task AddMessagesAsync()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Adding queue messages...");

            var queue = await GetQueueReference();
            await queue.ClearAsync();

            for (var messageId = 1; messageId <= 10; messageId++)
            {
                var message = new CloudQueueMessage($"Message # {messageId}");
                await queue.AddMessageAsync(message);
            }

            Console.WriteLine("Queue messages are added!");
        }

        private static async Task DeleteQueueAsync()
        {
            var queue = await GetQueueReference();

            await queue.DeleteAsync();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Queue deleted!");
        }

        private static async Task GetMessagesAsync()
        {
            await AddMessagesAsync();

            Console.ForegroundColor = ConsoleColor.Green;

            var queue = await GetQueueReference();

            var queueTopMessage = await queue.GetMessageAsync();
            Console.WriteLine($"Queue top message: {queueTopMessage.AsString}");

            queueTopMessage = await queue.GetMessageAsync();
            Console.WriteLine($"Queue top message: {queueTopMessage.AsString}");

            queueTopMessage = await queue.GetMessageAsync();
            Console.WriteLine($"Queue top message: {queueTopMessage.AsString}");

            Console.WriteLine("Queue top messages");
            var queueTopMessages = await queue.GetMessagesAsync(5);
            foreach (var message in queueTopMessages)
            {
                Console.WriteLine(message.AsString);
            }
        }

        private static async Task<CloudQueue> GetQueueReference()
        {
            var storageAccount = CloudStorageAccount.Parse(ConnectionString);
            var queueClient = storageAccount.CreateCloudQueueClient();
            var queue = queueClient.GetQueueReference("my-messages");

            await queue.CreateIfNotExistsAsync();

            return queue;
        }

        private static async Task PeekMessagesAsync()
        {
            await AddMessagesAsync();

            Console.ForegroundColor = ConsoleColor.Green;

            var queue = await GetQueueReference();

            var queueTopMessage = await queue.PeekMessageAsync();
            Console.WriteLine($"Queue top message: {queueTopMessage.AsString}");

            queueTopMessage = await queue.PeekMessageAsync();
            Console.WriteLine($"Queue top message: {queueTopMessage.AsString}");

            queueTopMessage = await queue.PeekMessageAsync();
            Console.WriteLine($"Queue top message: {queueTopMessage.AsString}");

            Console.WriteLine("Queue top messages");
            var queueTopMessages = await queue.PeekMessagesAsync(5);
            foreach (var message in queueTopMessages)
            {
                Console.WriteLine(message.AsString);
            }
        }
    }
}
