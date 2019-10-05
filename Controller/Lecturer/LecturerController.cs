using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;

namespace Advisor.Controller
{
    public class LecturerController : ILecturerController
    {
        public PopupLecturerComparisonView PopupLecturerComparisonView { get; set; }
        public void DisplayPopup()
        {
            PopupLecturerComparisonView = new PopupLecturerComparisonView();
            PopupLecturerComparisonView.ShowDialog();
        }
    }
}
