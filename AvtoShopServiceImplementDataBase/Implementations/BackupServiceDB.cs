using AvtoShopServiceDAL.BindingModel;
using AvtoShopServiceDAL.Interfaces;
using CourseWork;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace AvtoShopServiceImplementDataBase.Implementations
{
    public class BackupServiceDB : IBackupService
    {
        private CarDBContext context;

        public BackupServiceDB(CarDBContext context)
        {
            this.context = context;
        }

        public void BackupToJson(BackupBindingModel model)
        {
            DataContractJsonSerializer formatterClient = new DataContractJsonSerializer(typeof(List<Client>));
            MemoryStream msClient = new MemoryStream();
            formatterClient.WriteObject(msClient, context.Clients.ToList());
            msClient.Position = 0;
            StreamReader srClient = new StreamReader(msClient);
            string ClientsJSON = srClient.ReadToEnd();
            srClient.Close();
            msClient.Close();

            DataContractJsonSerializer Order = new DataContractJsonSerializer(typeof(List<Order>));
            MemoryStream msOrder = new MemoryStream();
            Order.WriteObject(msOrder, context.Orders.ToList());
            msOrder.Position = 0;
            StreamReader srOrder = new StreamReader(msOrder);
            string OrdersJSON = srOrder.ReadToEnd();
            srOrder.Close();
            msOrder.Close();

            DataContractJsonSerializer Car = new DataContractJsonSerializer(typeof(List<Car>));
            MemoryStream msCar = new MemoryStream();
            Car.WriteObject(msCar, context.Cars.ToList());
            msCar.Position = 0;
            StreamReader srCar = new StreamReader(msCar);
            string CarsJSON = srCar.ReadToEnd();
            srCar.Close();
            msCar.Close();


            DataContractJsonSerializer Payment = new DataContractJsonSerializer(typeof(List<Payment>));
            MemoryStream msPayment = new MemoryStream();
            Payment.WriteObject(msPayment, context.Payments.ToList());
            msPayment.Position = 0;
            StreamReader srPayment = new StreamReader(msPayment);
            string PaymentsJSON = srPayment.ReadToEnd();
            srPayment.Close();
            msPayment.Close();

            File.WriteAllText(model.FileName, "{\n" +
                "    \"Clients\": " + ClientsJSON + ",\n" +
                "    \"Orders\": " + OrdersJSON + ",\n" +
                "    \"Cars\": " + CarsJSON + ",\n" +
                "    \"Payments\": " + PaymentsJSON + ",\n" +
                "}");
        }

        public void BackupToXML()
        {
            DataContractJsonSerializer formatterClient = new DataContractJsonSerializer(typeof(List<Client>));
            XmlWriter writerClient = new XmlTextWriter(@"E:\client.xml", null);
            formatterClient.WriteObject(writerClient, context.Clients.ToList());
            writerClient.Close();

            DataContractJsonSerializer Order = new DataContractJsonSerializer(typeof(List<Order>));
            XmlWriter writerOrder = new XmlTextWriter(@"E:\Order.xml", null);
            Order.WriteObject(writerOrder, context.Orders.ToList());
            writerOrder.Close();

            DataContractJsonSerializer Car = new DataContractJsonSerializer(typeof(List<Car>));
            XmlWriter writerCar = new XmlTextWriter(@"E:\Car.xml", null);
            Car.WriteObject(writerCar, context.Cars.ToList());
            writerCar.Close();

            DataContractJsonSerializer Payment = new DataContractJsonSerializer(typeof(List<Payment>));
            XmlWriter writerPayment = new XmlTextWriter(@"E:\Payment.xml", null);
            Payment.WriteObject(writerPayment, context.Payments.ToList());
            writerPayment.Close();
        }
    }
}