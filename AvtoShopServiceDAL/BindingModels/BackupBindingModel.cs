using System.Runtime.Serialization;

namespace AvtoShopServiceDAL.BindingModel
{
    [DataContract]
    public class BackupBindingModel
    {
        [DataMember]
        public string FileName { get; set; }
    }
}
