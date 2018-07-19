using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace yzn.Controllers
{
    public abstract class yznControllerBase: AbpController
    {
        protected yznControllerBase()
        {
            LocalizationSourceName = yznConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
