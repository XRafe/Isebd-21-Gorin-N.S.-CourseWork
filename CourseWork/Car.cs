using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CourseWork
{
    [DataContract]
    public class Car
    {
        
        [DataMember]
        [Key]
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
