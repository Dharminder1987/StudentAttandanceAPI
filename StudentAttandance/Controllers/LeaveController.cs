using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly IDataRepository<Leave> _dataRepository;
        public LeaveController(IDataRepository<Leave> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataRepository.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_dataRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Add(Leave leave)
        {
            _dataRepository.Add(leave);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Leave leave)
        {
            _dataRepository.Update(leave);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _dataRepository.Delete(id);
            return NoContent();
        }
    }
}
