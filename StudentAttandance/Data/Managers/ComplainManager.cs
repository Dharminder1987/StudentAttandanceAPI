using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class ComplainManager : IDataRepository<Complain>
    {
        private readonly DataContext _complain;
        public ComplainManager(DataContext complain)
        {
            _complain = complain;
        }

        public void Add(Complain entity)
        {
            _complain.Add(entity);
            _complain.SaveChanges();
        }

        public void Delete(int id)
        {
            var complain = _complain.Complains.First(a => a.Id == id);
            if (complain != null)
            {
                _complain.Remove(complain);
                _complain.SaveChanges();
            }
        }

        public List<Complain> GetAll()
        {
            return _complain.Complains.ToList();
        }

        public Complain GetById(int id)
        {
            return _complain.Complains.First(x => x.Id == id);
        }

        public void Update(Complain entity)
        {
            _complain.Update(entity);
            _complain.SaveChanges();
        }
    }
}
