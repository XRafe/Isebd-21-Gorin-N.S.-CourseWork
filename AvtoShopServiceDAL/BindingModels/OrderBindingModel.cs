namespace AvtoShopServiceDAL.BindingModels
{
    public class OrderBindingModel
    {
        public int Id { set; get; }
        public int ClientId { set; get; }
        public string ClientFIO { set; get; }
        public int Count { set; get; }
        public int Sum { set; get; }
    }
}
