using Advisor.View;
using Advisor.Model;

namespace Advisor.Controller
{
    public class LecturerListController : ILecturerListController
    {
        public LecturerListView LecturerListView { get; set; }
        public Faculty Faculty { get; set; }

        public LecturerListController(Faculty faculty)
        {
            Faculty = faculty;
        }

        public void LoadLecturerData()
        {
            if(Faculty.Lecturers != null)
            {
                foreach (Lecturer lecturer in Faculty.Lecturers)
                {
                    LecturerListView.LecturerList.Items.Add(lecturer);
                }
            }
        }

        public void HandlePreviousFormButtonClick()
        {
            LecturerListView.Hide();
            FacultyView FacultyView = new FacultyView(new FacultyController(), Faculty, Faculty.University);
            FacultyView.Show();
        }

        public void HandleSelectedLecturer(string title)
        {
            //TODO: Show individual lecturers view
        }
    }
}
