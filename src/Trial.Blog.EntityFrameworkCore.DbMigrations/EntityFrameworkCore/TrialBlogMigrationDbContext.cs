using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Trial.Blog
{
    public class TrialBlogMigrationDbContext : AbpDbContext<TrialBlogMigrationDbContext>
    {
        public TrialBlogMigrationDbContext(DbContextOptions<TrialBlogMigrationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBlog();
        }
    }
}
