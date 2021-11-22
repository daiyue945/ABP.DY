using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ABP.DY.Web.Views
{
    public abstract class DYRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected DYRazorPage()
        {
            LocalizationSourceName = DYConsts.LocalizationSourceName;
        }
    }
}
