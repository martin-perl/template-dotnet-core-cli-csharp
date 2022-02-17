using System;
using System.Threading.Tasks;
using com.test.delegates;
using com.test.implementations;
using Microsoft.Extensions.Logging;

namespace com.test.header
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using ILoggerFactory loggerFactory =
                LoggerFactory.Create(builder =>
                    builder.AddSimpleConsole(options =>
                    {
                        options.IncludeScopes = true;
                        options.SingleLine = true;
                        options.TimestampFormat = "hh:mm:ss ";
                    }));

            ILogger<Program> logger = loggerFactory.CreateLogger<Program>();
            using (logger.BeginScope("[scope is enabled]"))
            {
                logger.LogInformation("Hello World!");
                logger.LogInformation("Logs contain timestamp and log level.");
                logger.LogInformation("Each log message is fit in a single line.");
            }
            Console.WriteLine("Hallo Welt!");

            // Instantiate the delegate.
            GetData dataDelegate = Data.AddDelegateMethod;

            // Call the delegate.
            Console.WriteLine(dataDelegate(1, 2));

            dataDelegate = Data.MultiplyDelegateMethod;

            // Call the delegate.
            Console.WriteLine(dataDelegate(1, 2));

            HttpGet httpGet = new HttpGet();
            await httpGet.Get();
        }
    }
}
