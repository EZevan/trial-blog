using Trial.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Trial.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}