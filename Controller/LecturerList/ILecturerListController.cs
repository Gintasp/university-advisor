using Advisor.View;

namespace Advisor.Controller
{
    public interface ILecturerListController
    {
        LecturerListView LecturerListView { get; set; }
        void LoadLecturerData();
        void HandlePreviousFormButtonClick();
        void HandleSelectedLecturer(string title);
    }
}
