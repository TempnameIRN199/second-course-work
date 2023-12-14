using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project.DB
{
    public class TypeSubject
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public EnumType Type { get; set; }
        public decimal Hours { get; set; }

        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}
