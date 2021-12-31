using ApplicationData.Models.StudentsModels;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDataAccess.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option) : base(option)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
