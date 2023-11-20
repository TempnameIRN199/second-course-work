using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Attendance
    {
        public int Id { get; set; }

        public int LessonId { get; set; }
        public virtual Lessons Lessons { get; set; }

        public int StudentId { get; set; }
        public virtual Students Students { get; set; }

        public string Status { get; set; }
    }
}
