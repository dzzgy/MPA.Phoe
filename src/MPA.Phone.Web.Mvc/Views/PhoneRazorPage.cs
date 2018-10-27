using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MPA.Phone.Web.Views
{
    public abstract class PhoneRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhoneRazorPage()
        {
            LocalizationSourceName = PhoneConsts.LocalizationSourceName;
        }
    }
}
