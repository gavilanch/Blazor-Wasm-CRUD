using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Client.Helpers
{
    public static class IJSRuntimeExtensions
    {
        public static ValueTask SaveAs(this IJSRuntime js, string fileName, byte[] content)
        {
            return js.InvokeVoidAsync("saveAsFile", fileName, Convert.ToBase64String(content));
        }

        public static ValueTask DisplayMessage(this IJSRuntime js, string message)
        {
            return js.InvokeVoidAsync("Swal.fire", message);
        }

        public static ValueTask DisplayMessage(this IJSRuntime js, string title, string message, SweetAlertMessageType sweetAlertMessageType)
        {
            return js.InvokeVoidAsync("Swal.fire", title, message, sweetAlertMessageType.ToString());
        }

        public static ValueTask<bool> Confirm(this IJSRuntime js, string title, string message, SweetAlertMessageType sweetAlertMessageType)
        {
            return js.InvokeAsync<bool>("CustomConfirm", title, message, sweetAlertMessageType.ToString());
        }

        public static ValueTask SetInLocalStorage(this IJSRuntime js, string key, string content)
   => js.InvokeVoidAsync(
       "localStorage.setItem",
       key, content
       );

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>(
                "localStorage.getItem",
                key
                );

        public static ValueTask RemoveItem(this IJSRuntime js, string key)
            => js.InvokeVoidAsync(
                "localStorage.removeItem",
                key);

    }

    public enum SweetAlertMessageType
    {
        question, warning, error, success, info
    }
}
