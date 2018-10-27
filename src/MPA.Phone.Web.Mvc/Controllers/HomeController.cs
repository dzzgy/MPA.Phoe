using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPA.Phone.Controllers;

namespace MPA.Phone.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhoneControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
