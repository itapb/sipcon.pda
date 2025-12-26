namespace Sipcon.Mobile.WebApp.Services
{
    using Sipcon.Mobile.WebApp.Enum;
    using Sipcon.Mobile.WebApp.Models;
    public interface IAuthorizeService
    {

        public Task Login(LoginResponse token);
        public Task Logout();
        public Task<bool> IsUserAuthenticated();
        public Task<List<UserModule>> GetUserRoleAsync();
        public Task<List<UserType>> GetUserDealerAsync();
        public Task<List<UserType>> GetUserSupplierAsync();
        public Task<User> GetUserAsync();
        public Task<int> GetSelectedDealerAsync();
        public Task<int> GetSelectedSupplierAsync();
        public Task SetValueSessionStorage<T>(T data, ValuesKey key);
        public Task RefreshStaticVariables();
        public Task RefresMobileStaticVariables(); 
    }
}
