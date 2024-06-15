using MRMDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace MRMDesktopUI.Library.Api
{
    public interface ISaleEndPoint
    {
        Task PostSale(SaleModel sale);
    }
}