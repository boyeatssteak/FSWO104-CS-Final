using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolEnrollmentApp.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Display(Name = "Course Number")]
        public int CourseNumber { get; set; }

        [Display(Name = "Course")]
        public string CourseFriendlyName
        {
            get
            {
                return CourseNumber + " - " + CourseName;
            }
        }

        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
