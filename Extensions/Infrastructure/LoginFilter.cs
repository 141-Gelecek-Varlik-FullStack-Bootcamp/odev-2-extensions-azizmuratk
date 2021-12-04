using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;

namespace Extensions.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string action = context.RouteData.Values["action"].ToString();
            string controller = context.RouteData.Values["controller"].ToString();

            var result = context.Result;

            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Has ignore attribute => access granted
            if (HasIgnoreAttribute(context))
            {
                return;
            }
            context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));
            return;
        }

        public bool HasIgnoreAttribute(FilterContext _context)
        {
            return ((ControllerActionDescriptor)_context.ActionDescriptor)
                .MethodInfo.CustomAttributes
                .Any(FilterDescriptor => FilterDescriptor.AttributeType == typeof(Ignore));
        }
    }
}
