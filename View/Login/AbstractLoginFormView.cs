using Advisor.Controller;
using System.Windows.Forms;

namespace Advisor.View
{
    public class AbstractLoginFormView : Form
    {
        public IAuthController AuthController { get; set; }
    }
}