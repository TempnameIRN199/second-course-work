using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Teachers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SubjectId { get; set; }
        public virtual Subjects Subjects { get; set; }

        public ICollection<Lessons> Lessons { get; set; }
    }
}
