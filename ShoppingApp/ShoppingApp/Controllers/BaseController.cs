using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShoppingApp.Controllers
{
    public class BaseController : Controller
    {
        
       public override void OnActionExecuting(ActionExecutingContext filter)
       {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserName")))
            {
                filter.Result = new RedirectToActionResult("Login", "User", null);
            }
            base.OnActionExecuting(filter);
       }
    
    }
}