using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace eManager.Controllers
{
    public abstract class eManagerControllerBase: AbpController
    {
        protected eManagerControllerBase()
        {
            LocalizationSourceName = eManagerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
