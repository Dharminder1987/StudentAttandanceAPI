using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class DivisionManager : IDataRepository<Division>
    {
        private readonly DataContext _division;
        public DivisionManager(DataContext division)
        {
            _division = division;
        }

        public void Add(Division entity)
        {
            _division.Add(entity);
            _division.SaveChanges();
        }

        public void Delete(int id)
        {
            var division = _division.Divisions.First(d => d.Id == id);
            _division.Remove(division);
            _division.SaveChanges();
        }

        public List<Division> GetAll()
        {
            return _division.Divisions.ToList();
        }

        public Division GetById(int id)
        {
            return _division.Divisions.First(x=>x.Id==id);
        }

        public void Update(Division entity)
        {
            _division.Update(entity);
            _division.SaveChanges();
        }
    }
}
