using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace test_1
{
    internal class testContext : DbContext
    {
        public testContext() : base("hentuhoConn")
        {

        }

        public DbSet<WeekDays> WeekDays { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
    }
}
