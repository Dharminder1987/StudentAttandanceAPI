using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class AttendanceManager : IDataRepository<Attendance>
    {
        private readonly DataContext _attendance;
        public AttendanceManager(DataContext attendance)
        {
            _attendance = attendance;
        }

        public void Add(Attendance entity)
        {
            _attendance.Add(entity);
            _attendance.SaveChanges();
        }

        public void Delete(int id)
        {
            var attendance = _attendance.Attendances.Find(id);
            if (attendance != null)
            {
                _attendance.Remove(attendance);
                _attendance.SaveChanges();
            }
        }

        public List<Attendance> GetAll()
        {
            return _attendance.Attendances.ToList();
        }

        public Attendance GetById(int id)
        {
            return _attendance.Attendances.Find(id);
        }

        public void Update(Attendance entity)
        {
            _attendance.Update(entity);
            _attendance.SaveChanges();
        }
    }
}
