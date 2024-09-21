using getting_started.Models;
using Microsoft.EntityFrameworkCore;

namespace getting_started.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
