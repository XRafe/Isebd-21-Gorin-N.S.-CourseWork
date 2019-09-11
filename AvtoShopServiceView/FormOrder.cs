using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using System.Data;

namespace AvtoShopServiceView
{
    public partial class FormOrder : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IClientService service;
        private readonly ICarService serviceB;
        private readonly IMainService serviceM;
        public FormOrder(IClientService service, ICarService serviceB, IMainService serviceM)
        {
            InitializeComponent();
            this.service = service;
            this.serviceB = serviceB;
            this.serviceM = serviceM;
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

                List<CarViewModel> list = serviceB.GetList();
                if (list != null)
                {
                    comboBoxCar.DisplayMember = "Firm";
                    comboBoxCar.ValueMember = "Id";
                    comboBoxCar.DataSource = list;
                    comboBoxCar.SelectedItem = null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void CalcSum()
        {
            if (comboBoxCar.SelectedValue != null &&
           !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxCar.SelectedValue);
                    CarViewModel Car = serviceB.GetElement(id);
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * Car.Price).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClient.SelectedValue == null)
            {
                MessageBox.Show("Выберите Клиента", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                serviceM.CreateOrder(new OrderBindingModel
                {
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Sum = Convert.ToInt32(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
    }
}
