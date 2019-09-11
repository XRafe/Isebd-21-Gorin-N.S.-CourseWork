using AvtoShopServiceDAL.BindingModel;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace AvtoShopServiceView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IMainService service;
        private readonly IBackupService backupService;

        public FormMain(IMainService service, IBackupService backupService)
        {
            InitializeComponent();
            this.service = service;
            this.backupService = backupService;
        }

        private void LoadData()
        {
            try
            {
                List<OrderViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCars>();
            form.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormOrder>();
            form.ShowDialog();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPayment>();
            form.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void бэкапXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                backupService.BackupToXML();
                MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void бэкапJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "json|*.json"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    backupService.BackupToJson(new BackupBindingModel
                    {
                        FileName = sfd.FileName,
                    });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
