using CoffeeShop.Application.Common.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace CoffeeShop.BlazorServerWebApplication.Components.Pages.Identity
{
    public partial class _LoginPartial
    {
        [Inject]
        private IConfiguration configuration { get; set; }

        private string test {  get; set; }

        private void SetConfig() => test = configuration.GetValue<string>("test");
    }
}
