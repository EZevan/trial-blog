﻿using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Trial.Blog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(TrialBlogApplicationModule)
        )]
    public class TrialBlogHttpApiModule : AbpModule
    {

    }
}
