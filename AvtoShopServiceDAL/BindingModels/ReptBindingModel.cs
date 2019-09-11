using System;
using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.BindingModels
{
    [DataContract]
    public class ReptBindingModel
    {
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public DateTime? DateFrom { get; set; }
        [DataMember]
        public DateTime? DateTo { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
