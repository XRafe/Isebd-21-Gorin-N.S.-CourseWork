using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.ViewModels
{
    [DataContract]
    public class OrderViewModel
    {
        [DataMember]
        public int Id { set; get; }
        [DataMember]
        public int ClientId { set; get; }
        [DataMember]
        public string ClientFIO { set; get; }
        [DataMember]
        public int Sum { set; get; }
        [DataMember]
        public int Count { set; get; }
        [DataMember]
        public string DateCreate { get; set; }
    }
}
