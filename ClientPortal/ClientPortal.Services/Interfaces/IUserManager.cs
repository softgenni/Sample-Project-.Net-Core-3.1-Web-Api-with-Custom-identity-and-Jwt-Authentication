using ClientPortal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientPortal.Services
{
    public interface IUserManager : IManagerBase<UserModel>
    {
        Task<UserModel> GetUserByIdAsync(string id);
    }
}
