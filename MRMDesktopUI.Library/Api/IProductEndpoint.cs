using MRMDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MRMDesktopUI.Library.Api
{
    public interface IProductEndpoint
    {
        Task<List<ProductModel>> GetAll();
    }
}