using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.DY.EntityFrameworkCore;
using ABP.DY.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABP.DY.Web.Tests
{
    [DependsOn(
        typeof(DYWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DYWebTestModule : AbpModule
    {
        public DYWebTestModule(DYEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DYWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DYWebMvcModule).Assembly);
        }
    }
}