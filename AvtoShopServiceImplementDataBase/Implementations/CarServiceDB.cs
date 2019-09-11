using AvtoShopServiceDAL.BindingModels;
using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceDAL.ViewModels;
using CourseWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvtoShopServiceImplementDataBase.Implementations
{
    public class CarServiceDB : ICarService
    {
        private CarDBContext context;
        public CarServiceDB(CarDBContext context)
        {
            this.context = context;
        }
        public List<CarViewModel> GetList()
        {
            List<CarViewModel> result = context.Cars.Select(rec => new
           CarViewModel
            {
                Id = rec.Id,
                Firm = rec.Firm,
                Model = rec.Model,
                Year = rec.Year,
                Price = rec.Price
            })
            .ToList();
            return result;
        }
        public CarViewModel GetElement(int id)
        {
            Car element = context.Cars.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new CarViewModel
                {
                    Id = element.Id,
                    Firm = element.Firm,
                    Model = element.Model,
                    Year = element.Year,
                    Price = element.Price
                };
            }
            throw new Exception("Элемент не найден");
        }
        public void AddElement(CarBindingModel model)
        {
            Car element = context.Cars.FirstOrDefault(rec => rec.Firm ==
           model.Firm && rec.Model == model.Model && rec.Year == model.Year);
            if (element != null)
            {
                throw new Exception("Уже есть данное авто");
            }
            context.Cars.Add(new Car
            {
                Firm = model.Firm,
                Model = model.Model,
                Year = model.Year,
                Price = model.Price
            });
            context.SaveChanges();
        }
        public void UpdElement(CarBindingModel model)
        {
            Car element = context.Cars.FirstOrDefault(rec => rec.Firm ==
           model.Firm && rec.Id != model.Id && rec.Model == model.Model && rec.Year == model.Year);
            if (element != null)
            {
                throw new Exception("Уже есть данное авто");
            }
            element = context.Cars.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Firm = model.Firm;
            context.SaveChanges();
        }
        public void DelElement(int id)
        {
            Car element = context.Cars.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Cars.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }
}
