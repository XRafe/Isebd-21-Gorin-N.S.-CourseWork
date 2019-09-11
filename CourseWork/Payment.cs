using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CourseWork
{
    [DataContract]
    public class Payment
    {

        [DataMember]
        [Key]
        public int OrderId { set; get; }
        [DataMember]
        public int Paid { set; get; }
        [DataMember]
        public string DatePay { set; get; }
    }
}
