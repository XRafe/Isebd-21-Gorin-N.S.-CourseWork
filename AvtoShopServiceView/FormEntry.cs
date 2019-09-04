using System;
using System.Windows.Forms;
using Unity;

namespace AvtoShopServiceView
{
    public partial class FormEntry : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormEntry()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" & textBoxPassword.Text == "admin") {
                var form = Container.Resolve<FormMain>();
                FormEntry.ActiveForm.Visible = false;
                form.ShowDialog();
                Close();
            } else
            {

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
