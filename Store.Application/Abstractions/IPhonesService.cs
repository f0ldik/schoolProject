using Store.Application.Models.Phones;

namespace Store.Application.Abstractions
{
    public interface IPhonesService
    {
         List<Phone> GetAll();
         Phone Get(uint id);
    }
}