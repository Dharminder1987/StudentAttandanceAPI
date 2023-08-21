using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class StaffManager :IDataRepository<Staff>
    {
        private readonly DataContext _staff;
        public StaffManager(DataContext staff)
        {
            _staff = staff;
        }

        public void Add(Staff entity)
        {
            _staff.Add(entity); 
            _staff.SaveChanges();
        }

        public void Delete(int id)
        {
            var St = _staff.Staffs.First(s => s.Id == id);
            if (St != null)
            {
                _staff.Staffs.Remove(St);
                _staff.SaveChanges();
            }
        }

        public List<Staff> GetAll()
        {
            return _staff.Staffs.ToList();
        }

        public Staff GetById(int id)
        {
            return _staff.Staffs.Find(id);
        }

        public void Update(Staff entity)
        {
            _staff.Update(entity);
            _staff.SaveChanges();
        }
    }
}
