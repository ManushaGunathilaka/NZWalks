using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    //https://localhost:portnumber/api/students  this is the uri to controller
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsContoller : ControllerBase
    {
        //this is the action method (get action)
        //GET: https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] students = new string[] { "manusha", "methsara", "kapila", "sunera", "kalpa" };
            return Ok(students); //return with 200ok response
        }
    }
}
