using System;
using Volo.Abp.Modularity;
using Volo.Abp.Caching;

namespace Trial.Blog.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(TrialBlogDomainModule)
    )]
    public class TrialBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
