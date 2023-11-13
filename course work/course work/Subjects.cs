using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Subjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


/*
 create table Subjects (
Id int not null identity primary key,
[Name] nvarchar(10) not null check([Name]!='')
)
 */