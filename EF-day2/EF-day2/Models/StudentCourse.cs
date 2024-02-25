using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_day2.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string SemesterInfo { get; set; }
        public int Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
