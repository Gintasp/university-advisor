namespace Advisor.Migrations
{
    using Advisor.Model;
    using Advisor.Service.Auth;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            PurgeDatabase(context);
            LoadTestData(context);
        }

        private void LoadTestData(DatabaseContext context)
        {
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\";

            //WARNING: The order of these function calls does matter
            LoadUsers(context, dataFolderPath + "User.csv");
            LoadReviews(context, dataFolderPath + "Review.csv");
            LoadCourses(context, dataFolderPath + "Course.csv");
            LoadStudyPrograms(context, dataFolderPath + "StudyProgram.csv");
            LoadLecturers(context, dataFolderPath + "Lecturer.csv");
            LoadUniversities(context, dataFolderPath + "University.csv");
            LoadFaculties(context, dataFolderPath + "Faculty.csv");

            LoadFacultyUniversityRelations(context);
            LoadLecturerFacultyRelations(context);
            LoadStudyProgramFacultyRelations(context);
            LoadCourseRelations(context);
            LoadReviewRelations(context);
        }

        private void LoadReviewRelations(DatabaseContext context)
        {
            Random r = new Random();
            var programs = context.StudyPrograms.ToList();
            var courses = context.Courses.ToList();
            var lecturers = context.Lecturers.ToList();
            var reviews = context.Reviews.ToList();

            foreach(Review review in reviews){
                if (review.Id % 3 == 0)
                {
                    review.Course = courses.ElementAt(r.Next(0, courses.Count));
                    context.SaveChanges();
                } else if (review.Id % 2 == 0 && review.StudyProgram == null)
                {
                    review.StudyProgram = programs.ElementAt(r.Next(0, programs.Count));
                    context.SaveChanges();
                } else if (review.StudyProgram == null && review.Course == null)
                {
                    review.Lecturer = lecturers.ElementAt(r.Next(0, lecturers.Count));
                    context.SaveChanges();
                }
            }
        }

        private void LoadCourseRelations(DatabaseContext context)
        {
            Random r = new Random();
            var courses = context.Courses.ToList();
            var programs = context.StudyPrograms.ToList();
            var lecturers = context.Lecturers.ToList();
            foreach(Course subject in courses)
            {
                subject.Lecturer = lecturers.ElementAt(r.Next(0, lecturers.Count));
                subject.StudyProgram = programs.ElementAt(r.Next(0, programs.Count));
                context.SaveChanges();
            }
        }

        private void LoadStudyProgramFacultyRelations(DatabaseContext context)
        {
            Random r = new Random();
            var programs = context.StudyPrograms.ToList();
            var faculties = context.Faculties.ToList();
            foreach (StudyProgram program in programs)
            {
                program.Faculty = faculties.ElementAt(r.Next(0, faculties.Count));
                context.SaveChanges();
            }
        }

        private void LoadLecturerFacultyRelations(DatabaseContext context)
        {
            Random r = new Random();
            var lecturers = context.Lecturers.ToList();
            var faculties = context.Faculties.ToList();
            foreach (Lecturer lecturer in lecturers)
            {
                lecturer.Faculty = faculties.ElementAt(r.Next(0, faculties.Count));
                context.SaveChanges();
            }
        }

        private void LoadFacultyUniversityRelations(DatabaseContext context)
        {
            Random r = new Random();
            var faculties = context.Faculties.ToList();
            var unis = context.Universities.ToList();
            foreach (Faculty fac in faculties)
            {
                fac.University = unis.ElementAt(r.Next(0, unis.Count));
                context.SaveChanges();
            }
        }

        private void LoadFaculties(DatabaseContext context, string filePath)
        {
            var facultyList = File.ReadAllLines(filePath).ToList();
            List<Faculty> facultiesToWrite = new List<Faculty>();
            foreach (string line in facultyList)
            {
                Faculty newFaculty = new Faculty()
                {
                    Title = line.Split(',')[0],
                    Description = line.Split(',')[1]
                };
                facultiesToWrite.Add(newFaculty);
            }

            context.Faculties.AddRange(facultiesToWrite);
            context.SaveChanges();
        }

        private void LoadUniversities(DatabaseContext context, string filePath)
        {
            var universityList = File.ReadAllLines(filePath).ToList();
            List<University> universitiesToWrite = new List<University>();
            foreach (string line in universityList)
            {
                University newUni = new University()
                {
                    Title = line.Split(',')[0],
                    Description = line.Split(',')[1]
                };
                universitiesToWrite.Add(newUni);
            }

            context.Universities.AddRange(universitiesToWrite);
            context.SaveChanges();
        }

        private void LoadLecturers(DatabaseContext context, string filePath)
        {
            var lecturerList = File.ReadAllLines(filePath).ToList();
            List<Lecturer> lecturersToWrite = new List<Lecturer>();
            foreach (string lecturer in lecturerList)
            {
                Lecturer newLecturer = new Lecturer()
                {
                    Name = lecturer
                };
                lecturersToWrite.Add(newLecturer);
            }

            context.Lecturers.AddRange(lecturersToWrite);
            context.SaveChanges();
        }

        private void LoadStudyPrograms(DatabaseContext context, string filePath)
        {
            var programList = File.ReadAllLines(filePath).ToList();
            List<StudyProgram> studyProgramsToWrite = new List<StudyProgram>();
            foreach (string line in programList)
            {
                StudyProgram newProgram = new StudyProgram()
                {
                    Title = line.Split(',')[0],
                    Description = line.Split(',')[1]
                };
                studyProgramsToWrite.Add(newProgram);
            }

            context.StudyPrograms.AddRange(studyProgramsToWrite);
            context.SaveChanges();
        }

        private void LoadCourses(DatabaseContext context, string filePath)
        {
            var courseList = File.ReadAllLines(filePath).ToList();
            List<Course> coursesToWrite = new List<Course>();
            foreach (string course in courseList)
            {
                Course newCourse = new Course() { Title = course };
                coursesToWrite.Add(newCourse);
            }

            context.Courses.AddRange(coursesToWrite);
            context.SaveChanges();
        }

        private void LoadReviews(DatabaseContext context, string filePath)
        {
            List<User> userList = context.Users.ToList();
            Random rand = new Random();

            var reviews = File.ReadAllLines(filePath).Select(
                line => new Review()
                {
                    Rating = int.Parse(line.Split(',')[1]),
                    Text = line.Split(',')[0],
                    UserId = userList.ElementAt(rand.Next(0, userList.Count)).Id
                }
            ).ToList();
            context.Reviews.AddRange(reviews);
            context.SaveChanges();
        }

        private void LoadUsers(DatabaseContext context, string filePath)
        {
            PasswordEncoder encoder = new PasswordEncoder();
            var users = File.ReadAllLines(filePath).Select(
                line => new User()
                {
                    Name = line.Split(',')[0],
                    Email = line.Split(',')[1],
                    Password = encoder.Encode("Pass1")
                }
            ).ToList();
            context.Users.AddRange(users);
            context.SaveChanges();
        }

        private void PurgeDatabase(DatabaseContext context)
        {
            //WARNING: The order of these function calls does matter
            context.Database.ExecuteSqlCommand("DELETE FROM [User]; DBCC CHECKIDENT ([User], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Course]; DBCC CHECKIDENT ([Course], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Lecturer]; DBCC CHECKIDENT ([Lecturer], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudyProgram]; DBCC CHECKIDENT ([StudyProgram], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Faculty]; DBCC CHECKIDENT ([Faculty], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [University]; DBCC CHECKIDENT ([University], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Review]; DBCC CHECKIDENT ([Review], RESEED, 0)");
        }
    }
}
