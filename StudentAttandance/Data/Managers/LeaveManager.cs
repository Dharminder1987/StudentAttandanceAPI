using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class LeaveManager : IDataRepository<Leave>
    {
        private readonly DataContext _leave;
        public LeaveManager(DataContext leave)
        {
            _leave = leave;
        }

        public void Add(Leave entity)
        {
            _leave.Add(entity);
            _leave.SaveChanges();
        }

        public void Delete(int id)
        {
            var le = _leave.Leaves.First(e => e.Id == id);
            if (le != null)
            {
                _leave.Leaves.Remove(le);
                _leave.SaveChanges();
            }
        }

        public List<Leave> GetAll()
        {
            return _leave.Leaves.ToList();
        }

        public Leave GetById(int id)
        {
            return _leave.Leaves.First(_e => _e.Id == id);  
        }

        public void Update(Leave entity)
        {
            _leave.Update(entity);
            _leave.SaveChanges();
        }
    }
}
