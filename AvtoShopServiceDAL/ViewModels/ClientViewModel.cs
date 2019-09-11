using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public string PassportData { set; get; }
        [DataMember]
        public string FIO { set; get; }
        [DataMember]
        public string NumberPhone { set; get; }
        [DataMember]
        public int Bonus { set; get; }
        [DataMember]
        public bool BlockStatus { set; get; }
        [DataMember]
        public List<OrderViewModel> Orders { get; set; }
    }
}
