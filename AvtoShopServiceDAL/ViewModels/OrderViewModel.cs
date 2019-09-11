using System;
using System.Collections.Generic;

namespace AvtoShopServiceDAL.ViewModels
{
    public class OrderViewModel
    {
        public int Id { set; get; }
        public int ClientId { set; get; }
        public string ClientFIO { set; get; }
        public int Sum { set; get; }
        public int Count { set; get; }
        public string DateCreate { get; set; }
    }
}
