using Microsoft.AspNetCore.Builder;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Trial.Blog.Swagger
{
    [DependsOn(
        typeof(TrialBlogDomainModule)
    )]
    public class TrialBlogSwaggerModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.GetApplicationBuilder()
                .UseSwagger()
                .UseSwaggerUI();
        }
    }
}
