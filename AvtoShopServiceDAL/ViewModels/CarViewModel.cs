using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.ViewModels
{
    [DataContract]
    public class CarViewModel
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
