using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Performances
    {
        public int Id { get; set; }
        public int GroupStudentId { get; set; }
        public int SubjectTeacherId { get; set; }
        public int GradeId { get; set; }
        public DateTime Date { get; set; }
    }
}


/*
create table Performances (
Id int not null identity primary key,
GroupStudentId int foreign key references GroupStudents(Id),
SubjectTeacherId int foreign key references SubjectTeachers(Id),
GradeId int foreign key references Grades(Id),
[Date] date not null
)
 */