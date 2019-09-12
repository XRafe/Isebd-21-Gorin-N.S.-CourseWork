using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.BindingModels
{
    [DataContract]
    public class PaymentBindingModel
    {
        [DataMember]
        public int OrderId { set; get; }
        [DataMember]
        public int Paid { set; get; }
        [DataMember]
        public string DatePay { set; get; }
    }
}
