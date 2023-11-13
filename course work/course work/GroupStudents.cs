using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class GroupStudent
    {
        [Key]
        public int Id { get; set; }

        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}



/*
create table GroupStudents (
Id int not null identity primary key,
GroupId int foreign key references Groups(Id),
StudentId int foreign key references Students(Id)
)
 */