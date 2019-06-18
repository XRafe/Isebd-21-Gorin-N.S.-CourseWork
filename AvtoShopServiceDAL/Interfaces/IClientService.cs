using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.ViewModels;
using System.Collections.Generic;

namespace AvtoShopServiceDAL.Interfaces
{
    public interface IClientService
    {
        List<ClientViewModel> GetList();
        ClientViewModel GetElement(int id);
        void AddElement(ClientBindingModel model);
        void UpdElement(ClientBindingModel model);
        void DelElement(int id);
    }
}
