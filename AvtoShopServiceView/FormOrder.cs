using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AvtoShopServiceView
{
    public partial class FormOrder : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IClientService service;
        public FormOrder(IClientService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCarOrder>();
            form.ShowDialog();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<ClientViewModel> listC = service.GetList();
                if (listC != null)
                {
                    comboBoxClient.DisplayMember = "FIO";
                    comboBoxClient.ValueMember = "Id";
                    comboBoxClient.DataSource = listC;
                    comboBoxClient.SelectedItem = null;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
