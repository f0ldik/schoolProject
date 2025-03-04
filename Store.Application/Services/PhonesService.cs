using Microsoft.EntityFrameworkCore;
using Store.Application.Abstractions;
using Store.Core.Models.Phones;
using Store.Data;
using System.Text.Json;

namespace Store.Application.Services
{
    public class PhonesService21 : IPhonesService
    {
        public Phone Get(Guid id)
        {
            return null;
        }

        public List<Phone> GetAll()
        {
            return [];
        }
    }

    public class PhonesService : IPhonesService
    {
        private ShopContext _shopContext;

        public PhonesService(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public List<Phone> GetAll()
        {
            return _shopContext.Phones.ToList();
        }

        public Phone Get(Guid id)
        {
            return _shopContext.Phones.AsNoTracking().FirstOrDefault(f => f.Id == id);
        }

        public void Add(Phone phone)
        {
            _shopContext.Phones.Add(phone);
            _shopContext.SaveChanges();
        }

        public void Update(Phone phone)
        {
            _shopContext.Entry(phone).State = EntityState.Modified;
            _shopContext.SaveChanges();
        }

        //public void Update2(Phone phone)
        //{
        //    var originalPhone = Get(phone.Id);
        //    originalPhone.Width = phone.Width;
        //    originalPhone.Height = phone.Height;
        //    originalPhone.Model = phone.Model;
        //    originalPhone.Price = phone.Price; 
        //    _shopContext.SaveChanges();
        //}

        //public void UpgradePrice(Guid id, int newPrice)
        //{
        //    var phone = Get(id);
        //    if (phone is not null) 
        //    {
        //        phone.Price = newPrice;
        //        _shopContext.SaveChanges();
        //    }
        //}

        public void Delete(Guid id)
        {
            var phone = Get(id);

                _shopContext.Phones.Remove(phone);
                _shopContext.SaveChanges();
        }
    }
}