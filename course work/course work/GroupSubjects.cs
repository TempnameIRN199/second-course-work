using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class GroupSubjects
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int SubjectId { get; set; }
    }
}


/*
create table GroupSubjects (
Id int not null identity primary key,
GroupId int foreign key references Groups(Id),
SubjectId int foreign key references Subjects(Id)
)
 */