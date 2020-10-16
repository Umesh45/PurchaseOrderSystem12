using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POWebServices.Interfaces
{
    //public interface IMessageSender
    //{
    //    Task Send(string content);
    //}

    //public class AzureQueueSender : IMessageSender
    //{
    //    public AzureQueueSender(IConfiguration configuration)
    //    {
    //        Configuration = configuration;
    //    }
    //    public IConfiguration Configuration { get; }

    //    public async Task Send(string content)
    //    {
    //       var connectionString = Configuration.GetValue<string>("QueueConnectionString");
    //        await SendMessage(connectionString);
    //    }

    //    private static async Task SendMessage(string connectionString)
    //    {
    //      var storageAccount =  CloudStorageAccount.Parse(connectionString);
    //        storageAccount.CreateCloudQueueClient();
    //        var queueClient = storageAccount.CreateCloudQueueClient();

    //        var que=queueClient.GetQueueReference()


    //    }
    //}
}
