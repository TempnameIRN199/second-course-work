using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace course_work
{
    internal class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public ICollection<GroupStudent> GroupStudent { get; set; }
    }
}

/*
create table Groups (
Id int not null identity primary key,
[Name] nvarchar(10) not null check([Name]!= '')
)
*/