using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Students
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<GroupStudents> GroupStudents { get; set; }
    }
}


/*
create table Students (
Id int not null identity primary key,
GroupId int foreign key references Groups(Id),
Surname nvarchar(50) not null check(Surname!=''),
FirstName nvarchar(50) not null check(FirstName!=''),
Patronymic nvarchar(50) not null check(Patronymic!='')
)
 */