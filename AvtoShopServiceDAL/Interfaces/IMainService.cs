using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.ViewModels;
using System.Collections.Generic;

namespace AvtoShopServiceDAL.Interfaces
{
    public interface IMainService
    {
        List<OrderViewModel> GetList();
        void CreateOrder(OrderBindingModel model);
        void PayOrder(OrderBindingModel model);
    }
}
