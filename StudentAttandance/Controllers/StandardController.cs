using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandardController : ControllerBase
    {
        private readonly IDataRepository<Standard> _dataRepository;
        public StandardController(IDataRepository<Standard> dataRepository)
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
        public IActionResult Add(Standard standard)
        {
            _dataRepository.Add(standard);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Standard standard)
        {
            _dataRepository.Update(standard);
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
