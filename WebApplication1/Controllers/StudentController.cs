using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public void GetStudent()
        {

        }
        [HttpDelete]
        public void DeleteStudent()
        {

        }
        [HttpPost]
        public void PostStudent()
        {

        }
        [HttpPut]
        public void PutStudent()
        {

        }


    }
}
