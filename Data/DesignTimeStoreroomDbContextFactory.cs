using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace storeroom_web_netcore.Data
{
    public class DesignTimeStoreroomDbContextFactory : IDesignTimeDbContextFactory<StoreroomDbContext>
    {
        public DesignTimeStoreroomDbContextFactory()
        {
        }

        public StoreroomDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder();
            builder.UseSqlServer(configuration.GetConnectionString("Storeroom"));

            return new StoreroomDbContext(builder.Options);
        }
    }
}