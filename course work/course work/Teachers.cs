using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Teachers
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
    }
}


/*
 create table Teachers (
Id int not null identity primary key,
Surname nvarchar(50) not null check(Surname!=''),
FirstName nvarchar(50) not null check(FirstName!=''),
Patronymic nvarchar(50) not null check(Patronymic!='')
)
 */