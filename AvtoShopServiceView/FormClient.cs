using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using System;
using System.Windows.Forms;
using Unity;

namespace AvtoShopServiceView
{
    public partial class FormClient : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public static bool checkstatus = false;
        public int Id { set { id = value; } }
        private readonly IClientService service;
        private int? id;

        public FormClient(IClientService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    service.UpdElement(new ClientBindingModel
                    {
                        Id = id.Value,
                        FIO = textBoxFIO.Text,
                        PassportData = textBoxPassport.Text,
                        NumberPhone = textBoxPhone.Text,
                        Bonus = Int32.Parse(textBoxBonuses.Text),
                        BlockStatus = checkstatus
                    });
                }
                else
                {
                    service.AddElement(new ClientBindingModel
                    {
                        FIO = textBoxFIO.Text,
                        PassportData = textBoxPassport.Text,
                        NumberPhone = textBoxPhone.Text,
                        Bonus = Int32.Parse(textBoxBonuses.Text),
                        BlockStatus = checkstatus
                    });
                }
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

        private void FormClient_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ClientViewModel view = service.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckStatusClient_CheckedChanged(object sender, EventArgs e)
        {
            if (checkstatus == false)
            {
                checkstatus = true;
            } else
            {
                checkstatus = false;
            }
        }
    }
}
