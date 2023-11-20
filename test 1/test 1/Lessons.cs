using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Lessons
    {
        public int Id { get; set; }

        public int WeekDayId { get; set; }
        public virtual WeekDays WeekDays { get; set; }

        public int SubjectId { get; set; }
        public virtual Subjects Subjects { get; set; }

        public int TeacherId { get; set; }
        public virtual Teachers Teachers { get; set; }

        public int GroupId { get; set; }
        public virtual Groups Groups { get; set; }

        public ICollection<Attendance> Attendance { get; set; }
    }
}
