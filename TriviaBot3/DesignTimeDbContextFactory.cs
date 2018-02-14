using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TriviaBot3.Models;

namespace TriviaBot3
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TriviaContext>
    {
        public TriviaContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<TriviaContext>();

            var connectionString = configuration.GetConnectionString("TriviaContext");

            builder.UseSqlServer(connectionString);

            return new TriviaContext(builder.Options);
        }
    }
}
