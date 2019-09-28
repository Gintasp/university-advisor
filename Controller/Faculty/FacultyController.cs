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

        public void LoadStudyProgramData(ListView listView)
        {
            //TODO: Load items from DB
            listView.Items.Clear();
            listView.Items.Add("Programu sistemos");
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram));
            StudyProgramView.Show();
        }
    }
}
