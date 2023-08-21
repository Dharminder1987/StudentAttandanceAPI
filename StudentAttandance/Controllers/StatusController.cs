using Microsoft.AspNetCore.Mvc;
using StudentAttandance.ViewModel;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<StatusVM> statusList = new List<StatusVM>() 
            {  
                new StatusVM() { StatusId = 1, StatusName = "Present" },
                new StatusVM() { StatusId = 2, StatusName = "Absent" }
            };
            return Ok(statusList);
        }
    }
}
