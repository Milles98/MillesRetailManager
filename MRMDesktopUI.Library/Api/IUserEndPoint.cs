using MRMDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MRMDesktopUI.Library.Api
{
    public interface IUserEndPoint
    {
        IAPIHelper _apiHelper { get; }

        Task<List<UserModel>> GetAll();
    }
}