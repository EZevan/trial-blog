using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp;

namespace Trial.Blog.HttpApi.Hosting
{
    public class Startup
    {
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddApplication<TrialBlogHttpApiHostingModule>( );
        //}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<TrialBlogHttpApiHostingModule>(options =>
            {
                //Integrate Autofac!
                //options.UseAutofac();
            });           
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
