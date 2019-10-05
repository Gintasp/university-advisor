using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;

namespace Advisor.Controller.Lecturer
{
    class LecturerController : ILecturerController
    {
        public PopupLecturerComparison PopupLecturerComparison { get; set; }

        public void DisplayPopup()
        {
            PopupLecturerComparison = new PopupLecturerComparison();
            PopupLecturerComparison.ShowDialog();
        }
    }
}
