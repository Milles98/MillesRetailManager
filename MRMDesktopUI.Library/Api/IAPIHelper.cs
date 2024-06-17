using MRMDesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace MRMDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        void LogOffUser();
        Task GetLoggedInUserInfo(string token);
    }
}