using Advisor.Controller;
using System.Windows.Forms;

namespace Advisor.View
{
    public class ALoginFormView : Form
    {
        public IAuthController AuthController { get; set; }
    }
}