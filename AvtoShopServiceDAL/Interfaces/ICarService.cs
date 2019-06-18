using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.ViewModels;
using System.Collections.Generic;

namespace AvtoShopServiceDAL.Interfaces
{
    public interface ICarService
    {
        List<CarViewModel> GetList();
        CarViewModel GetElement(int id);
        void AddElement(CarBindingModel model);
        void UpdElement(CarBindingModel model);
        void DelElement(int id);
    }
}
