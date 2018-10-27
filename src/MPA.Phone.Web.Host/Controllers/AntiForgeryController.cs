using Microsoft.AspNetCore.Antiforgery;
using MPA.Phone.Controllers;

namespace MPA.Phone.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
