using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.ViewModels
{
    [DataContract]
    public class PaymentViewModel
    {
        [DataMember]
        public int OrderId { set; get; }
        [DataMember]
        public int Paid { set; get; }
        [DataMember]
        public string DatePay { set; get; }
    }
}
