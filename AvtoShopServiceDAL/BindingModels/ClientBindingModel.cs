using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.BindingModels
{
    [DataContract]
    public class ClientBindingModel
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
    }
}
