
using Assgiment02.Models;
using Microsoft.EntityFrameworkCore;

namespace Assgiment02.Dbcontexts
{
    internal class ITIDbcontext : DbContext
    {
        public ITIDbcontext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITIEFCore ; Trusted_Connection = true");
        }


        // Mapping using By Convention
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

    }
}

