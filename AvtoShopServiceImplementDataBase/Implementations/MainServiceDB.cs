using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using CourseWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace AvtoShopServiceImplementDataBase.Implementations
{
    public class MainServiceDB : IMainService
    {
        private CarDBContext context;
        public MainServiceDB(CarDBContext context)
        {
            this.context = context;
        }
        public List<OrderViewModel> GetList()
        {
            List<OrderViewModel> result = context.Orders.Select(rec => new OrderViewModel
            {
                Id = rec.Id,
                Count = rec.Count,
                ClientId = rec.ClientId,
                DateCreate = SqlFunctions.DateName("dd", rec.DateCreate)
           + " " +
            SqlFunctions.DateName("mm", rec.DateCreate) +
           " " +
            SqlFunctions.DateName("yyyy",
           rec.DateCreate),
                Sum = rec.Sum,
                ClientFIO = rec.Client.FIO
            })
            .ToList();
            return result;
        }
        public void CreateOrder(OrderBindingModel model)
        {
            context.Orders.Add(new Order
            {
                ClientId = model.ClientId,
                DateCreate = DateTime.Now,
                Count = model.Count,
                Sum = model.Sum,
            });
            context.SaveChanges();
        }

        public void PayOrder(OrderBindingModel model)
        {
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.SaveChanges();
        }
    }
}
