using System.Threading.Tasks;

namespace BethanysPieShopHRM.ServerApp.Services.LocalStorage
{
  public class LocalStorageService : ILocalStorageService
  {
    public async Task SetItemAsync<T>(string key, T item)
    {
      // TODO: Store item in local storage
    }

    public async Task<T> GetItemAsync<T>(string key)
    {
      // TODO: Get item from local storage
      return default;
    }
  }
}
