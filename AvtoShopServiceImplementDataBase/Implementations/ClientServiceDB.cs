using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using CourseWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvtoShopServiceImplementDataBase.Implementations
{
    public class ClientServiceDB : IClientService
    {
        private CarDBContext context;
        public ClientServiceDB(CarDBContext context)
        {
            this.context = context;
        }
        public List<ClientViewModel> GetList()
        {
            List<ClientViewModel> result = context.Clients.Select(rec => new
           ClientViewModel
            {
                Id = rec.Id,
                FIO = rec.FIO,
                PassportData = rec.PassportData,
                NumberPhone = rec.NumberPhone,
            })
            .ToList();
            return result;
        }
        public ClientViewModel GetElement(int id)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ClientViewModel
                {
                    Id = element.Id,
                    FIO = element.FIO,
                    PassportData = element.PassportData,
                    NumberPhone = element.NumberPhone
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(ClientBindingModel model)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.FIO ==
           model.FIO && rec.PassportData == model.FIO && rec.NumberPhone == model.NumberPhone);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            context.Clients.Add(new Client
            {
                FIO = model.FIO,
                PassportData = model.PassportData,
                NumberPhone = model.NumberPhone
            });
            context.SaveChanges();
        }
        public void UpdElement(ClientBindingModel model)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.FIO ==
           model.FIO && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть клиент с таким ФИО");
            }
            element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.FIO = model.FIO;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Client element = context.Clients.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Clients.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
