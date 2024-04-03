using CoffeeShop.Application.Common.Entities.Mssql;
using CoffeeShop.Infrastructure.Interface;
using CoffeeShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Infrastructure.Services
{
    public class UserDataService : IUserDataService
    {
        private CoffeeDbContext _context;

        public UserDataService(CoffeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserEntity>> GetUserDataByUserIdAsync(string userId)
        {
            if (userId == null)
            {
                return null;
            }

            return await _context.Users
                .Where(x => x.UserId.ToLower().Equals(userId))
                .ToListAsync();
        }
    }
}
