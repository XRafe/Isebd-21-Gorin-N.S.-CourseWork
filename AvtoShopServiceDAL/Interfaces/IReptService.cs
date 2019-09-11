using AvtoShopServiceDAL.Attributies;
using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.ViewModels;
using System.Collections.Generic;

namespace AvtoShopServiceDAL.Interfaces
{
    public interface IReptService
    {
        [UsageMethod("Метод добавления отчёта excel")]
        void SaveCarPriceXls(ReptBindingModel model);
        [UsageMethod("Метод добавления отчёта word")]
        void SaveCarPriceW(ReptBindingModel model);
        [UsageMethod("Метод получения списка заказов")]
        List<OrderViewModel> GetClientOrders(ReptBindingModel model);
        [UsageMethod("Метод получения списка заказов для клиента")]
        List<OrderViewModel> GetClientOrdersForClients(ReptBindingModel model, int ClientId);
        [UsageMethod("Метод получения отчёта по id")]
        void SaveClientOrders(ReptBindingModel model);
        [UsageMethod("Метод получения отчёта по заказам для клиента")]
        void SaveClientOrdersForClients(ReptBindingModel model, int ClientId);
        [UsageMethod("Метод добавления отчёта по клиенту word")]
        void SaveOrderClientXls(ReptBindingModel model, ClientViewModel Client);
        [UsageMethod("Метод добавления отчёта по клиенту word")]
        void SaveOrderClientW(ReptBindingModel model, ClientViewModel Client);
    }
}
