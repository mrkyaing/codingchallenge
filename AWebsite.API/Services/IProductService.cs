using AWebsite.API.Models;

namespace AWebsite.API.Services
{
    public interface IProductService
    {
        Product GetById(int id);
        Product Create(Product product);
    }
}
