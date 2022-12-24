using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet(Name = "students")]
        public IEnumerable<String> Get()
        {
            yield return "hello world";
        }
    }
}
