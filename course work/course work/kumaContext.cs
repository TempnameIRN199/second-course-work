using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace course_work
{
    internal class hentuhoContext : DbContext
    {
        public hentuhoContext() : base("hentuhoConn")
        {
            //Database.SetInitializer<hentuhoContext>(new CreateDatabaseIfNotExists<hentuhoContext>());
        }

        public DbSet<Groups> Groups { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<GroupStudents> GroupStudents { get; set; }
        //public DbSet<Grades> Grades { get; set; }
        //public DbSet<Subjects> Subjects { get; set; }
        //public DbSet<Teachers> Teachers { get; set; }
        //public DbSet<GroupSubjects> GroupSubjects { get; set; }
        //public DbSet<SubjectTeachers> SubjectTeachers { get; set; }
        //public DbSet<Performances> Performances { get; set; }
    }
}
