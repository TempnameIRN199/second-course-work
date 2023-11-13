using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class GroupStudents
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int StudentId { get; set; }

        public virtual Groups Group { get; set; }
        public virtual Students Student { get; set; }
    }
}



/*
create table GroupStudents (
Id int not null identity primary key,
GroupId int foreign key references Groups(Id),
StudentId int foreign key references Students(Id)
)
 */