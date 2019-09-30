using System.Collections.ObjectModel;
using System.Windows.Forms;
using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class FacultyController : IFacultyController
    {
        public FacultyView FacultyView { get; set; }
        public FacultyListView FacultyListView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyView.Hide();
            FacultyListView = new FacultyListView(new FacultyListController(this), uni);
            FacultyListView.Show();
        }

        public void LoadStudyProgramData(Faculty faculty)
        {
            //TODO: Load items from DB

            FacultyView.StudyProgramList.Items.Clear();
            foreach (StudyProgram studyProgram in faculty.StudyPrograms)
            {
                FacultyView.StudyProgramList.Items.Add(studyProgram);
            }

            
            Collection<Review> reviews = new Collection<Review>();
            reviews.Add(new Review() { Text = "Test review" });
            StudyProgram program = new StudyProgram()
            {
                Title = "Study Program",
                Description = "This is a test study program description",
                Reviews = reviews
            };
            //listBox.Items.Clear();
            //listBox.Items.Add(program);
            
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }
    }
}
