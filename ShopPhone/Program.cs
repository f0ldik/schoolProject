using ShopPhone.ConsoleApp.Helpers;
using Store.Data;

namespace ShopPhone.ConsoleApp
{
    static class Program
    {
        public static void Main()
        {

            //var db = new ShopContext();

            //foreach (var item in db.Phones)
            //{
            //    Console.WriteLine($"{item.Id} - {item.Model} - {item.Price}");
            //}

            //db.Phones.Add(new Phone { Price = 500, Procesor = "new procesor", Model = "new phone", Id = Guid.Empty });
            //db.SaveChanges();

            //var a = db.Phones.FirstOrDefault(f => f.Id == Guid.Empty);
            //a.Price = a.Price + 50;

            //if (a != null)
            //{
            //    db.Phones.Remove(a);
            //    db.SaveChanges();
            //}

            //return;


            //var list = SeedPhoneCollection.GetAll();
            //var service = new PhonesService();
            //foreach (var item in list)
            //    service.Add(item);

            Console.WriteLine("Online shop phone");
            MenuHelper.MainMenu();

        }
    }
}