using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolEnrollmentApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolEnrollmentAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<SchoolEnrollmentAppContext>>()))
            {
                // Check if any students or courses already exist
                if (context.Student.Any() || context.Course.Any())
                {
                    return;
                }

                var students = new Student[]
                {
                    new Student { FirstName = "Homestar", LastName = "Runner" },
                    new Student { FirstName = "The", LastName = "Cheat" },
                    new Student { FirstName = "Strong", LastName = "Bad" },
                    new Student { FirstName = "Strong", LastName = "Sad" },
                    new Student { FirstName = "Coach", LastName = "Z" },
                    new Student { FirstName = "Strong", LastName = "Mad" },
                    new Student { FirstName = "The", LastName = "Poopsmith" },
                    new Student { FirstName = "King", LastName = "of Town" },
                    new Student { FirstName = "Clever", LastName = "Dan" }
                };
                foreach (Student s in students)
                {
                    context.Student.Add(s);
                }
                context.SaveChanges();

                var courses = new Course[]
                {
                    new Course { CourseNumber = 4368, CourseName = "History of StrongBadia" },
                    new Course { CourseNumber = 8789, CourseName = "Liking Techno, at all." },
                    new Course { CourseNumber = 8623, CourseName = "Whether or not The Cheat is Dead" },
                    new Course { CourseNumber = 5497, CourseName = "Light Switch Raves" },
                    new Course { CourseNumber = 7225, CourseName = "Legends of Trogdor" },
                    new Course { CourseNumber = 7310, CourseName = "Checking Email" }
                };
                foreach (Course c in courses)
                {
                    context.Course.Add(c);
                }
                context.SaveChanges();

                context.Enrollments.AddRange(
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Homestar" && s.LastName == "Runner").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8623).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Homestar" && s.LastName == "Runner").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Homestar" && s.LastName == "Runner").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Homestar" && s.LastName == "Runner").StudentId, CourseId = courses.Single(c => c.CourseNumber == 4368).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Cheat").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8789).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Cheat").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Cheat").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7225).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Cheat").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8623).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Bad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Bad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7225).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Bad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Bad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8623).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Sad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Sad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8789).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Sad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7225).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Sad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 4368).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Coach" && s.LastName == "Z").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8789).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Coach" && s.LastName == "Z").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7225).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Coach" && s.LastName == "Z").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Coach" && s.LastName == "Z").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8623).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Mad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 4368).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Mad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Mad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8789).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Strong" && s.LastName == "Mad").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Poopsmith").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Poopsmith").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Poopsmith").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8789).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "The" && s.LastName == "Poopsmith").StudentId, CourseId = courses.Single(c => c.CourseNumber == 4368).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "King" && s.LastName == "of Town").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8789).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "King" && s.LastName == "of Town").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8623).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "King" && s.LastName == "of Town").StudentId, CourseId = courses.Single(c => c.CourseNumber == 4368).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "King" && s.LastName == "of Town").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Clever" && s.LastName == "Dan").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7225).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Clever" && s.LastName == "Dan").StudentId, CourseId = courses.Single(c => c.CourseNumber == 8623).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Clever" && s.LastName == "Dan").StudentId, CourseId = courses.Single(c => c.CourseNumber == 7310).CourseID },
                    new Enrollments { StudentId = students.Single(s => s.FirstName == "Clever" && s.LastName == "Dan").StudentId, CourseId = courses.Single(c => c.CourseNumber == 5497).CourseID }
                    );
                context.SaveChanges();
            }
        }
    }
}
