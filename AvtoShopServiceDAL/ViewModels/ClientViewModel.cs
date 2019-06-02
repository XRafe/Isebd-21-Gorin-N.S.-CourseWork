namespace AvtoShopServiceDAL.ViewModels
{
    class ClientViewModel
    {
        public int Id { set; get; }
        public string PassportData { set; get; }
        public string FIO { set; get; }
        public string NumberPhone { set; get; }
        public int Bonus { set; get; }
        public bool BlockStatus { set; get; }
    }
}
