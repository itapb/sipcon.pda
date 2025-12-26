
using Sipcon.Mobile.WebApp.Enum;

namespace Sipcon.Mobile.WebApp.Services
{
    public interface ISessionStorageService
    {
        Task<T> GetValue<T>(ValuesKey key);

        Task SetValue<T>(ValuesKey key,  T value);

        Task RemoveValue(ValuesKey key);
        Task SetTimerInactivo<T>(T value);

        Task ClearAll();

    }
}
