using GSL.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GSL.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts(string token);
        Task<ProductModel> FindProductById(long id, string token);
        Task<ProductModel> CreateProduct(ProductModel model, string token);
        Task<ProductModel> UpdateProduct(ProductModel model, string token);
        Task<bool> DeleteProductById(long id, string token);
    }
}
