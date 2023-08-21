using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class StandardManager : IDataRepository<Standard>
    {
        private readonly DataContext _context;
        public StandardManager(DataContext context)
        {
            _context = context;
        }

        public void Add(Standard entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Std = _context.Standards.Find(id);
            if (Std != null)
            {
                _context.Remove(Std);
                _context.SaveChanges();
            }
        }

        public List<Standard> GetAll()
        {
            return _context.Standards.ToList();
        }

        public Standard GetById(int id)
        {
            return _context.Standards.First(x=>x.Id==id);
        }

        public void Update(Standard entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
