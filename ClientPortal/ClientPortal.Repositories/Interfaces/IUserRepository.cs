using ClientPortal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientPortal.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserProfileById(string id);
    }
}
