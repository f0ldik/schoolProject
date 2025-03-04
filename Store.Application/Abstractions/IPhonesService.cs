using Store.Core.Models.Phones;

namespace Store.Application.Abstractions
{
    public interface IPhonesService
    {
         List<Phone> GetAll();
         Phone Get(Guid id);
    }
}