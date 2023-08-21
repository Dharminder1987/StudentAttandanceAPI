using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IDataRepository<Student> _dataRepository;
        public StudentController(IDataRepository<Student> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataRepository.GetAll());
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            _dataRepository.Add(student);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
         return Ok(_dataRepository.GetById(id));
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
         _dataRepository.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(Student student)
        {
            _dataRepository.Update(student);
            return Ok();
        }
    }
}
