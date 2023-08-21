using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data.Managers
{
    public class StudentManager : IDataRepository<Student>
    {
        private readonly DataContext _context;
        public StudentManager(DataContext context)
        {
            _context = context;
        }

        public void Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Stud = _context.Students.First(x => x.Id == id);
            _context.Remove(Stud);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();  
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public void Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
        }
    }
}
