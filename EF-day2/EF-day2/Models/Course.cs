using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        //public int DepartmentId { get; set; }
        //public virtual Department Department { get; set; }

        //public virtual ICollection<Student>Students { get; set; }  

    }
}
