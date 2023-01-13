using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Models;

namespace StudentEnrollment.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
        
        public DbSet<Student> students { get; set; }
        public DbSet<Country> country { get; set; }

        public DbSet<Subject> subjects { get; set; }

    }
}
