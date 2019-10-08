using System;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class SelectPopup : Form
    {
        public event EventHandler<EventArgs> SelectClick;
        public event EventHandler<EventArgs> ViewLoad;
        public event EventHandler<EventArgs> FirstComboSelect;
        public event EventHandler<EventArgs> SecondComboSelect;
        public ComboBox ComboLast { get; set; }
        public ComboBox ComboSecond { get; set; }
        public ComboBox ComboFirst { get; set; }
        public Label LabelLast { get; set; }

        public SelectPopup()
        {
            InitializeComponent();
            ComboFirst = Combo1;
            ComboSecond = Combo2;
            ComboLast = Combo3;
            LabelLast = Label3;
        }

        private void OnSelectClick(object sender, EventArgs e)
        {
            SelectClick?.Invoke(this, EventArgs.Empty);
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            ViewLoad?.Invoke(this, EventArgs.Empty);
        }

        private void OnComboFirstSelect(object sender, EventArgs e)
        {
            FirstComboSelect?.Invoke(this, EventArgs.Empty);
        }

        private void OnComboSecondSelect(object sender, EventArgs e)
        {
            SecondComboSelect?.Invoke(this, EventArgs.Empty);
        }
    }
}
