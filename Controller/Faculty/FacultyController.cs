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

        public void LoadStudyProgramData(ListBox listBox)
        {
            //TODO: Load items from DB
            Collection<Review> reviews = new Collection<Review>();
            reviews.Add(new Review() { Text = "Test review" });
            Collection<StudySubject> studySubjects = new Collection<StudySubject>();
            studySubjects.Add(new StudySubject() { Title = "Test study subject" });
            StudyProgram program = new StudyProgram()
            {
                Title = "Study Program",
                Description = "This is a test study program description",
                Reviews = reviews,
                StudySubjects = studySubjects
            };
            listBox.Items.Clear();
            listBox.Items.Add(program);
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }
    }
}
