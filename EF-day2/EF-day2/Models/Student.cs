using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day2.Models
{
    public class Student
    {
        //[Key]
        //public int StudentId { get; set; }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }

        //[ForeignKey("Department")]    → Data annotation
        //public int DeptId { get; set; }
        public int DepartmentId { get; set; }  // variable name must be like the Department name (Department => DepartmentId) Naming convention

        public virtual Department Department { get; set; }  //lazy loading

        //public virtual ICollection<Course>Courses { get; set; }  // the first method to make many to many relation(make 2 ICollections)



    }
}
