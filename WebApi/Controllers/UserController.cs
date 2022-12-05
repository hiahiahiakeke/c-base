using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public string Get()
        {
            return "这是一个get请求";
        }
    }

}
