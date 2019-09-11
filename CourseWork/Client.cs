using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CourseWork
{
    [DataContract]
    public class Client
    {

        [DataMember]
        [Key]
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
        [ForeignKey("ClientId")]
        public virtual List<Order> Orders { get; set; }
        public virtual List<Car> Cars { get; set; }
    }
}
