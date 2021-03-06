using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Trial.Blog
{
    [DependsOn(typeof(TrialBlogEntityFrameworkCoreModule))]
    public class TrialBlogEntityFrameworkCoreDbMigrationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TrialBlogMigrationDbContext>();
        }
    }
}
