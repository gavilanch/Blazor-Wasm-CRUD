using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Client.Pages
{
    public partial class Counter
    {
        [CascadingParameter] private Task<AuthenticationState> authenticationState { get; set; }

        int currentCount = 10;
        [Parameter] public int IncrementBy { get; set; } = 1;

        async Task IncrementCount()
        {
            var authState = await authenticationState;
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                currentCount += IncrementBy;
                Console.WriteLine(user.Identity.Name);
            }
            else
            {
                currentCount -= IncrementBy;
            }
        }
    }
}
