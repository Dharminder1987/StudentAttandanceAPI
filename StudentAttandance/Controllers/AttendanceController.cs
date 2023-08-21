using Microsoft.AspNetCore.Mvc;
using StudentAttandance.Data;
using StudentAttandance.Data.Entity;
using StudentAttandance.ViewModel;

namespace StudentAttandance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IDataRepository<Attendance> _attendance;
        public AttendanceController(IDataRepository<Attendance> attendance)
        {
            _attendance = attendance;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_attendance.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_attendance.GetById(id));
        }

        [HttpPost]
        public IActionResult Add(AttendanceVM atten)
        {
            Attendance attendance = new Attendance()
            {
                Name = atten.Name,
                RollNumber = atten.RollNumber,
                StaffName = atten.StaffName,
                AttendanceDate = atten.AttendanceDate,
                Status = atten.Status,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = 1,
                IsDeleted = false
            };
            _attendance.Add(attendance);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Update(AttendanceVM atten)
        {
            Attendance attendance = new Attendance()
            {
                Id = atten.Id,
                Name = atten.Name,
                RollNumber = atten.RollNumber,
                StaffName = atten.StaffName,
                AttendanceDate = atten.AttendanceDate,
                Status = atten.Status,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = 1,
                IsDeleted = false
            };
            _attendance.Update(attendance);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _attendance.Delete(id);
            return NoContent();
        }
    }
}
