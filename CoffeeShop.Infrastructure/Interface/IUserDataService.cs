using CoffeeShop.Application.Common.Entities.Mssql;

namespace CoffeeShop.Infrastructure.Interface
{
    public interface IUserDataService
    {
        public Task<List<UserEntity>> GetUserDataByUserIdAsync(string userId);
    }
}
