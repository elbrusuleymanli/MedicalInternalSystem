using MedApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;


namespace MedApi.Infrastructures.Filters
{
    public class Auth: ActionFilterAttribute
    {
        private readonly IUserService _userService;

        public Auth(IUserService userService)
        {
            _userService = userService;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool hasHeader = context.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues token);

            if (!hasHeader)
            {
                context.Result = new UnauthorizedResult();
            }

            var user = _userService.CheckToken(token.ToString()).Result;

            if (user == null)
            {
                context.Result = new UnauthorizedResult();
            }
            context.RouteData.Values["User"] = user;
        }
    }
}
