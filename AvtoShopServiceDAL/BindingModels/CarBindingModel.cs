using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.BindingModels
{
    [DataContract]
    public class CarBindingModel
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public string Firm { set; get; }
        [DataMember]
        public string Model { set; get; }
        [DataMember]
        public int Year { set; get; }
        [DataMember]
        public int Price { set; get; }
    }
}
