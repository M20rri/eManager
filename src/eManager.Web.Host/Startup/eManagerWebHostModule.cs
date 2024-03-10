using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eManager.Configuration;

namespace eManager.Web.Host.Startup
{
    [DependsOn(
       typeof(eManagerWebCoreModule))]
    public class eManagerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public eManagerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eManagerWebHostModule).GetAssembly());
        }
    }
}
