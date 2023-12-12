using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace course_project.DB
{
    public class Attendance
    {
        public int Id { get; set; }
        public int TypeSubjectId { get; set; }
        public virtual TypeSubject TypeSubject { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public EnumSkip Skip { get; set; }
        public DateTime Date { get; set; }
        public int NumberLesson { get; set; }
    }
}
