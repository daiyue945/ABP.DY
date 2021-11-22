using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABP.DY.Web.Views
{
    public abstract class DYViewComponent : AbpViewComponent
    {
        protected DYViewComponent()
        {
            LocalizationSourceName = DYConsts.LocalizationSourceName;
        }
    }
}
