using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project.DB
{
    public class NintendoContext : DbContext
    {
        public NintendoContext() : base("Nintendo")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<NintendoContext>());
        }

        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TypeSubject> TypeSubject { get; set; }
        public DbSet<Subject> Subject { get; set; }
    }
}
