using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MPA.Phone.Controllers
{
    public abstract class PhoneControllerBase: AbpController
    {
        protected PhoneControllerBase()
        {
            LocalizationSourceName = PhoneConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
