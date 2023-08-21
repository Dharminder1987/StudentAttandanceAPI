using Microsoft.EntityFrameworkCore;
using StudentAttandance.Data.Entity;

namespace StudentAttandance.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Complain> Complains { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
