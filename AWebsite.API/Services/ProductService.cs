using AWebsite.API.Models;

namespace AWebsite.API.Services
{
    public class ProductService : IProductService
    {
        public Product GetById(int id)
        {
            // Simulate retrieving a product
            return new Product { Id = id, Name = "Sample Product" };
        }

        public Product Create(Product product)
        {
            // Simulate creating a product
            product.Id = new Random().Next(1, 1000);
            return product;
        }
    }
}
