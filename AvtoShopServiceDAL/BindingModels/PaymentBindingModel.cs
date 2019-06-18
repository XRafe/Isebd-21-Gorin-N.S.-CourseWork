namespace AvtoShopServiceDAL.BindingModels
{
    public class PaymentBindingModel
    {
        public int OrderId { set; get; }
        public int Paid { set; get; }
        public string DatePay { set; get; }
    }
}
