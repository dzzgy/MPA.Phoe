using Abp.AspNetCore.Mvc.ViewComponents;

namespace MPA.Phone.Web.Views
{
    public abstract class PhoneViewComponent : AbpViewComponent
    {
        protected PhoneViewComponent()
        {
            LocalizationSourceName = PhoneConsts.LocalizationSourceName;
        }
    }
}
