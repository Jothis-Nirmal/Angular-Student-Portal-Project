using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortalAngular.DataModels
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options):base(options) 
        { 

        }
        public DbSet<Student> student { get; set; }
        public DbSet<Gender> gender { get; set; }
        public DbSet<Address> addresse { get; set; }
    }
}
