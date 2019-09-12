using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Unity;

namespace AvtoShopServiceView
{
    public partial class FormReport : Form
    {
        
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IReptService service;
        private readonly IClientService serviceC;
        private int? id;
        private List<OrderViewModel> Order;
        public FormReport(IReptService service, IClientService serviceC)
        {
            InitializeComponent();
            this.service = service;
            this.serviceC = serviceC;
        }

        private void buttonSaveToExcel_Click(object sender, EventArgs e)
        {
            var model = serviceC.GetElement(id.Value);

        

            service.SaveOrderClientXls(new ReptBindingModel
            {
                FileName = "E:\\ReportOrderXls.xls"
            }, model);
        }



        private void FormReport_Load_1(object sender, EventArgs e)
        {
                if (id.HasValue)
                {
                    try
                    {
                        ClientViewModel view = serviceC.GetElement(id.Value);
                        if (view != null)
                        {
                            Order = view.Orders;
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Order = new List<OrderViewModel>();
                }
            
        }
    }
}
