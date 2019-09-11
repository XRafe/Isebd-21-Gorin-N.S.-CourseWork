using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CourseWork
{

    [DataContract]
    public class Order
    {

        [DataMember]
        [Key]
        public int Id { set; get; }
        [DataMember]
        public int ClientId { set; get; }
        [DataMember]
        public int Count { set; get; }
        [DataMember]
        public int Sum { set; get; }
        [DataMember]
        public DateTime DateCreate { set; get; }
        [DataMember]
        public string ClientFIO { set; get; }


        public virtual Client Client { get; set; }
        public virtual Car Car { get; set; }

    }
}
