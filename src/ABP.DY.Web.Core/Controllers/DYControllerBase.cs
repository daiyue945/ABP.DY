using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABP.DY.Controllers
{
    public abstract class DYControllerBase: AbpController
    {
        protected DYControllerBase()
        {
            LocalizationSourceName = DYConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
