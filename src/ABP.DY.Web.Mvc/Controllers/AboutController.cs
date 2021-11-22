using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABP.DY.Controllers;

namespace ABP.DY.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : DYControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
