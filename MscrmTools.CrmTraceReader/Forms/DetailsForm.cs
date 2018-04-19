using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.CrmTraceReader.Forms
{
    public partial class DetailsForm : DockContent
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            richTextBox1.Text = text;
        }
    }
}