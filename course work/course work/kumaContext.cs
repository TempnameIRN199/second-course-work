using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Emit;

namespace course_work
{
    internal class hentuhoContext : DbContext
    {
        public hentuhoContext() : base("hentuhoConn")
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GroupStudent> GroupStudents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Определите здесь настройки модели, если это необходимо
        }

        //public DbSet<Grades> Grades { get; set; }
        //public DbSet<Subjects> Subjects { get; set; }
        //public DbSet<Teachers> Teachers { get; set; }
        //public DbSet<GroupSubjects> GroupSubjects { get; set; }
        //public DbSet<SubjectTeachers> SubjectTeachers { get; set; }
        //public DbSet<Performances> Performances { get; set; }
    }
}
