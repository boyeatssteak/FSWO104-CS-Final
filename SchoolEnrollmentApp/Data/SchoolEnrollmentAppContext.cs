using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolEnrollmentApp.Models;

namespace SchoolEnrollmentApp.Models
{
    public class SchoolEnrollmentAppContext : DbContext
    {
        public SchoolEnrollmentAppContext (DbContextOptions<SchoolEnrollmentAppContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolEnrollmentApp.Models.Course> Course { get; set; }

        public DbSet<SchoolEnrollmentApp.Models.Student> Student { get; set; }

        public DbSet<SchoolEnrollmentApp.Models.Enrollments> Enrollments { get; set; }
    }
}
