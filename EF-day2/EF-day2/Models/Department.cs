using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day2.Models
{
    public class Department
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Student> Students { get; set; }

       // public virtual ICollection<Course> Courses { get; set; }
    }
}
