using Microsoft.AspNetCore.Antiforgery;
using yzn.Controllers;

namespace yzn.Web.Host.Controllers
{
    public class AntiForgeryController : yznControllerBase
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
