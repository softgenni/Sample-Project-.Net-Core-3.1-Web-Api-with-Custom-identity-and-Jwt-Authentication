using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPortal.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }

        public async Task<User> GetUserProfileById(string id)
        {
            IQueryable<User> query = this.context.Set<User>().Where(x => x.Id == id);
            query = query.Include(x => x.UserRole)
                .ThenInclude(x=>x.Role)
                .AsNoTracking();
            var data = await query.FirstOrDefaultAsync();
            return data;
        }
    }
}
