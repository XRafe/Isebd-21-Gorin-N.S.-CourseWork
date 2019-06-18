namespace AvtoShopServiceDAL.ViewModels
{
    public class OrderViewModel
    {
        public int Id { set; get; }
        public int ClientId { set; get; }
        public int Sum { set; get; }
        public string CreationDate { set; get; }
        public string DateImplement { get; set; }
    }
}
