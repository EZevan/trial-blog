using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.Blog
{
    public class TrialBlogMigrationDbContextFactory : IDesignTimeDbContextFactory<TrialBlogMigrationDbContext>
    {
        public TrialBlogMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TrialBlogMigrationDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"),ServerVersion.AutoDetect(configuration.GetConnectionString("Default")));

            return new TrialBlogMigrationDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
        }
    }
}
