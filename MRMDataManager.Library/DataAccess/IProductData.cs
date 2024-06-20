using MRMDataManager.Library.Models;
using System.Collections.Generic;

namespace MRMDataManager.Library.DataAccess
{
    public interface IProductData
    {
        ProductModel GetProductById(int productId);
        List<ProductModel> GetProducts();
    }
}