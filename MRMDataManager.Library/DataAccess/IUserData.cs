using MRMDataManager.Library.Models;
using System.Collections.Generic;

namespace MRMDataManager.Library.DataAccess
{
    public interface IUserData
    {
        List<UserModel> GetUserById(string Id);
    }
}