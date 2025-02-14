using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ibksWeb.Controllers;

public class BaseController : Controller
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserLoggedIn")))
        {
            context.Result = RedirectToAction("Login", "Account"); // Giriş sayfasına yönlendir
        }
        base.OnActionExecuting(context);
    }
}
