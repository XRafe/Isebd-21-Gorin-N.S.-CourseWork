using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.BindingModels
{
    [DataContract]
    public class OrderBindingModel
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public int ClientId { set; get; }
        [DataMember]
        public string ClientFIO { set; get; }
        [DataMember]
        public int Count { set; get; }
        [DataMember]
        public int Sum { set; get; }
    }
}
