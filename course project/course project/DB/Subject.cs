using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace course_project.DB
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public decimal TotalHours { get; set; }

        public virtual ICollection<TypeSubject> TypeSubject { get; set; }
    }
}
