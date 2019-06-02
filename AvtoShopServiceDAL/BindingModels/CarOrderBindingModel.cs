namespace AvtoShopServiceDAL.BindingModels
{
    class CarOrderBindingModel
    {
        public int Id { set; get; }
        public int CarId { set; get; }
        public int OrderId { set; get; }
        public int Count { set; get; }
    }
}
