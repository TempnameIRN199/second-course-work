using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace course_work
{
    internal class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupStudents> GroupStudents { get; set; }
    }
}

/*
create table Groups (
Id int not null identity primary key,
[Name] nvarchar(10) not null check([Name]!= '')
)
*/