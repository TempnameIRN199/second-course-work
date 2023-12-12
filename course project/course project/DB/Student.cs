using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project.DB
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set;}
        public int RBNumber { get; set; } // номер залікової книжки

        public virtual ICollection<Attendance> Attendance { get; set; }
    }
}
