using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;
using System.Data;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplainController : ControllerBase
    {
        private readonly IDataRepository<Complain> _dataRepository;
        public ComplainController(IDataRepository<Complain> dataRepository)
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
        public IActionResult Add(Complain complain)
        {
            _dataRepository.Add(complain);
            return NoContent();
        }
        [HttpPut]
        public IActionResult Update(Complain complain)
        {
            _dataRepository.Update(complain);
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
