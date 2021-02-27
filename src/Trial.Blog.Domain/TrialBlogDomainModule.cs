using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Trial.Blog
{
    [DependsOn(
        typeof(AbpIdentityDomainModule)
    )]
    public class TrialBlogDomainModule : AbpModule
    {

    }
}
