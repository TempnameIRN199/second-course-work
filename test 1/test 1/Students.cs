using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Students
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GroupId { get; set; }
        public virtual Groups Groups { get; set; }

        public ICollection<Attendance> Attendance { get; set; }
    }
}
