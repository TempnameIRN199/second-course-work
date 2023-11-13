using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string Patronymic { get; set; }

        //[ForeignKey("GroupId")]
        //public int GroupId { get; set; }

        
        //public virtual Group Group { get; set; }

        public ICollection<GroupStudent> GroupStudent { get; set; }
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