using SqlApp.Models;

namespace SqlApp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}