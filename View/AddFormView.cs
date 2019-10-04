using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class AddFormView : Form
    {
        public Label TitleLabel { get; set; }
        public TextBox TitleInput { get; set; }
        public RichTextBox DescriptionInput { get; set; }
        public Label DescriptionLabel { get; set; }
        public event EventHandler<EventArgs> AddButtonClicked;
        public AddFormView()
        {
            InitializeComponent();
            TitleLabel = Title;
            TitleInput = TextBox;
            DescriptionInput = RichTextBox;
            DescriptionLabel = DescLabel;
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
