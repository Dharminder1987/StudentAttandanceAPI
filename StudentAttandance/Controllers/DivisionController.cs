using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly IDataRepository<Division> _repository;
        public DivisionController(IDataRepository<Division> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Add(Division division)
        {
            _repository.Add(division);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Division division)
        {
            _repository.Update(division);
            return NoContent();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}
