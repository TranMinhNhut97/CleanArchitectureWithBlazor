using CoffeeShop.Application.Common.Configuration;
using CoffeeShop.Application.Common.Interfaces;
using Microsoft.Extensions.Options;

namespace CoffeeShop.Application.Services
{
    public class UserService : IUserService
    {
        private readonly ConfigurationModel _configurationModel;
        public UserService(IOptions<ConfigurationModel> option)
        {
            _configurationModel = option.Value;
        }
    }
}
