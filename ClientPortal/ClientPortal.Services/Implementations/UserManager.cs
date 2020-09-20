using AutoMapper;
using ClientPortal.Entities;
using ClientPortal.Models;
using ClientPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientPortal.Services
{
    public class UserManager : ManagerBase<UserModel, User>, IUserManager
    {
        private readonly IUserRepository UserRepository;
        public UserManager(IUserRepository repository, IMapper mapper) : base(repository, mapper)
        {
            UserRepository = repository;
        }

        public async Task<UserModel> GetUserByIdAsync(string id)
        {
            var result = await UserRepository.GetUserProfileById(id);
            return Mapper.Map<UserModel>(result);
        }
    }
}
