using AutoMapper;
using MedApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace MedApi.Controllers
{
    [Route("v{ver:apiVersion}/[controller]")]  //(router budur)
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IMapper _mapper => HttpContext.RequestServices.GetService<IMapper>();
        protected User _user => RouteData.Values["User"] as User;

    }
}
