using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Trial.Blog
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule)
        )]
    public class TrialBlogApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpAutoMapperOptions>(options =>
            //{
            //    options.AddMaps<TrialBlogApplicationModule>();
            //});
        }
    }
}
