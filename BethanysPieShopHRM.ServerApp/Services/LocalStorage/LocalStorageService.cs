using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.ServerApp.Services.LocalStorage
{
  public class LocalStorageService : ILocalStorageService
  {
        private readonly IJSRuntime _jsRunTime;

        public LocalStorageService(IJSRuntime jsRuntime)
        {
            _jsRunTime = jsRuntime;
        }
    public async Task SetItemAsync<T>(string key, T item)
    {
            await _jsRunTime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(item));
    }

    public async Task<T> GetItemAsync<T>(string key)
    {
            var json = await _jsRunTime.InvokeAsync<string>("localStorage.getItem", key);

            return string.IsNullOrEmpty(json) ? default : JsonSerializer.Deserialize<T>(json);
    }
  }
}
