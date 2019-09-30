namespace Advisor.Migrations
{
    using Advisor.Model;
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
            LoadStudySubjects(context, dataFolderPath + "StudySubject.csv");
            LoadStudyPrograms(context, dataFolderPath + "StudyProgram.csv");
            LoadLecturers(context, dataFolderPath + "Lecturer.csv");
            LoadUniversities(context, dataFolderPath + "University.csv");
            LoadFaculties(context, dataFolderPath + "Faculty.csv");

            LoadFacultyUniversityRelations(context);
            LoadLecturerFacultyRelations(context);
            LoadStudyProgramFacultyRelations(context);
            LoadStudySubjectRelations(context);
            LoadReviewRelations(context);
        }

        private void LoadReviewRelations(DatabaseContext context)
        {
            Random r = new Random();
            var programs = context.StudyPrograms.ToList();
            var subjects = context.StudySubjects.ToList();
            var lecturers = context.Lecturers.ToList();

            var programReviews = context.Reviews.ToArray().Select(
                (item, i) => new { Review = item, Index = i }
            ).Where(
                element => element.Index % 3 == 0
            ).Select(element => element.Review);

            var subjectReviews = context.Reviews.ToArray().Select(
                (item, i) => new { Review = item, Index = i }
            ).Where(
                element => element.Index % 2 == 0 && element.Review.StudyProgram == null
            ).Select(element => element.Review);

            var lecturerReviews = context.Reviews.Where(
                rev => rev.StudySubject == null && rev.StudyProgram == null
            ).Select(rev => rev);

            foreach (Review review in programReviews)
            {
                review.StudyProgram = programs.ElementAt(r.Next(0, programs.Count));
            }
            context.SaveChanges();

            foreach (Review review in subjectReviews)
            {
                review.StudySubject = subjects.ElementAt(r.Next(0, subjects.Count));
            }
            context.SaveChanges();

            foreach (Review review in lecturerReviews)
            {
                review.Lecturer = lecturers.ElementAt(r.Next(0, lecturers.Count));
            }
            context.SaveChanges();
        }

        private void LoadStudySubjectRelations(DatabaseContext context)
        {
            Random r = new Random();
            var subjects = context.StudySubjects.ToList();
            var programs = context.StudyPrograms.ToList();
            var lecturers = context.Lecturers.ToList();
            foreach(StudySubject subject in subjects)
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
            foreach (string faculty in facultyList)
            {
                Faculty newFaculty = new Faculty() { Title = faculty };
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
            foreach (string program in programList)
            {
                StudyProgram newProgram = new StudyProgram() { Title = program };
                studyProgramsToWrite.Add(newProgram);
            }

            context.StudyPrograms.AddRange(studyProgramsToWrite);
            context.SaveChanges();
        }

        private void LoadStudySubjects(DatabaseContext context, string filePath)
        {
            var subjectList = File.ReadAllLines(filePath).ToList();
            List<StudySubject> studySubjectsToWrite = new List<StudySubject>();
            foreach (string subject in subjectList)
            {
                StudySubject newSubject = new StudySubject() { Title = subject };
                studySubjectsToWrite.Add(newSubject);
            }

            context.StudySubjects.AddRange(studySubjectsToWrite);
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
            var users = File.ReadAllLines(filePath).Select(
                line => new User()
                {
                    Name = line.Split(',')[0],
                    Email = line.Split(',')[1],
                    Password = "pass"
                }
            ).ToList();
            context.Users.AddRange(users);
            context.SaveChanges();
        }

        private void PurgeDatabase(DatabaseContext context)
        {
            //WARNING: The order of these function calls does matter
            context.Database.ExecuteSqlCommand("DELETE FROM [User]; DBCC CHECKIDENT ([User], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudySubject]; DBCC CHECKIDENT ([StudySubject], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Lecturer]; DBCC CHECKIDENT ([Lecturer], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [StudyProgram]; DBCC CHECKIDENT ([StudyProgram], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Faculty]; DBCC CHECKIDENT ([Faculty], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [University]; DBCC CHECKIDENT ([University], RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Review]; DBCC CHECKIDENT ([Review], RESEED, 0)");
        }
    }
}
