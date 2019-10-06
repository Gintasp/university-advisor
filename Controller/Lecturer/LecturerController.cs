using System.Collections.Generic;
using System.Linq;
using Advisor.View;
using Advisor.Model;

namespace Advisor.Controller
{
    public class LecturerController : ILecturerController
    {
        public LecturerView LecturerView { get; set; }
        public FacultyView FacultyView { get; set; }
        public CourseView CourseView { get; set; }
        public AddFormView AddFormView { get; set; }
        public Lecturer Lecturer { get; set; }

        public LecturerController(Lecturer lecturer)
        {
            Lecturer = lecturer;
        }

        public void LoadLecturerData()
        {
            LecturerView.Lecturer = Lecturer;
            LecturerView.CourseList.Items.Clear();
            LecturerView.ReviewList.Items.Clear();

            if(Lecturer.Courses != null)
            {
                List<Course> courses = Lecturer.Courses.ToList();
                courses.ForEach(course => LecturerView.CourseList.Items.Add(course));
            }
            
            if(Lecturer.Reviews != null)
            {
                List<Review> reviews = Lecturer.Reviews.ToList();
                reviews.ForEach(review => LecturerView.ReviewList.Items.Add(review));
            }
        }

        public void HandleLeaveReviewClick()
        {
            //TODO: Implement opening review form
        }

        public void HandlePreviousFormClick()
        {
            LecturerView.Hide();
            FacultyView = new FacultyView(new FacultyController(), Lecturer.Faculty, Lecturer.Faculty.University);
            FacultyView.Show();
        }

        //public void HandleCourseSelect(Course course)
        //{
        //    LecturerView.Hide();
        //    CourseView = new CourseView(new CourseController(course.StudyProgram, course, new StudyProgramController(course.StudyProgram, Lecturer.Faculty, Lecturer.Faculty.University)), course);
        //    CourseView.Show();
        //}
        //
        //public void HandleAddCourseClick()
        //{
        //    LoadAddForm();
        //    AddFormView.ShowDialog();
        //}
        //
        //public void HandleAddCourse(object sender, EventArgs e)
        //{
        //    Course course = new Course()
        //    {
        //        Title = AddFormView.TitleInput.Text,
        //        Lecturer = Lecturer,
        //        StudyProgram = (StudyProgram)AddFormView.LecturerComboBox.SelectedItem,
        //        Reviews = new Collection<Review>()
        //    };
        //    DB.Instance.Courses.Add(course);
        //    DB.Instance.SaveChanges();
        //    LecturerView.CourseList.Items.Add(course);
        //    AddFormView.Close();
        //}
        //
        //public void LoadAddForm()
        //{
        //    AddFormView = new AddFormView();
        //    AddFormView.TitleLabel.Text = "Add course";
        //    AddFormView.TextFieldLabel.Text = "Name:";
        //    AddFormView.DescriptionInput.Visible = false;
        //    AddFormView.DescriptionLabel.Visible = false;
        //    AddFormView.LecturerComboBox.Visible = true;
        //    AddFormView.LecturerLabel.Visible = true;
        //    AddFormView.LecturerLabel.Text = "Choose a study program";
        //    AddFormView.AddButtonClicked += HandleAddCourse;
        //    List<StudyProgram> studyPrograms = Lecturer.Faculty.StudyPrograms.ToList();
        //    studyPrograms.ForEach(program => AddFormView.LecturerComboBox.Items.Add(program));
        //}
    }
}
