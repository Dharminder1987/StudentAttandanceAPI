using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IDataRepository<Staff> _staffRepository;
        public StaffController(IDataRepository<Staff> staffRepository)
        {
            _staffRepository = staffRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_staffRepository.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_staffRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Add(Staff staff)
        {
            _staffRepository.Add(staff);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Staff staff)
        {
            _staffRepository.Update(staff);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _staffRepository.Delete(id);
            return NoContent();
        }
    }
}
