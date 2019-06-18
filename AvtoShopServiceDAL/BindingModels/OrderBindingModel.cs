namespace AvtoShopServiceDAL.BindingModels
{
    public class OrderBindingModel
    {
        public int Id { set; get; }
        public int ClientId { set; get; }
        public int Sum { set; get; }
        public string CreationDate { set; get; }
        public string DateImplement { get; set; }
    }
}
