using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class SubjectTeachers
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
    }
}


/*
create table SubjectTeachers (
Id int not null identity primary key,
SubjectId int foreign key references Subjects(Id),
TeacherId int foreign key references Teachers(Id)
)
 */