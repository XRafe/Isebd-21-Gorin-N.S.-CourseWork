using System.Collections.Generic;

namespace AvtoShopServiceDAL.ViewModels
{
    public class CarViewModel
    {
        public int Id { set; get; }
        public string Firm { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public int Price { set; get; }
    }
}
