using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_project.DB
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set;}

        public virtual ICollection<TypeSubject> TypeSubject { get; set; }
    }
}
