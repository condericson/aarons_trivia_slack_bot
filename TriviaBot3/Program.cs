using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TriviaBot3.Models;

namespace TriviaBot3
{
    class Program
    {
        private static IConfigurationRoot Configuration { get; set; }
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContextPool<TriviaContext>(options =>
                options.UseSqlServer(config.GetConnectionString("TriviaContext")));

            serviceCollection.AddSingleton<SlackHelper>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            serviceProvider.GetService<TriviaContext>().Database.Migrate();

            var slackHelper = serviceProvider.GetService<SlackHelper>();

            try
            {
                slackHelper.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }
    }
}
