using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace IdentityServer.Host.Support
{
    public static class Extensions
    {
        public static async Task<ClaimsPrincipal> GetIdentityServerUserAsync(this HttpContext context)
        {
            var result = await context.AuthenticateAsync();
            return result.Principal;
        }
    }
}
