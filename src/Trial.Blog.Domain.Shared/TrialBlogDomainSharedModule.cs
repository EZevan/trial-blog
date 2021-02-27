using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Trial.Blog
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule)
    )]
    public class TrialBlogDomainSharedModule : AbpModule
    {
     
    }
}
