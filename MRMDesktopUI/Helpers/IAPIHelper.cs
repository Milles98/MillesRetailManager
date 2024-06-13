using MRMDesktopUI.Models;
using System.Threading.Tasks;

namespace MRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}