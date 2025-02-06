using Microsoft.AspNetCore.Authorization;

namespace Thursday_ProductManagement.WebApi.Helper
{
    public class BasicAuthorizationAttribute : AuthorizeAttribute
    {
        public BasicAuthorizationAttribute()
        {
            AuthenticationSchemes = BasicAuthenticationDefaults.AuthenticationScheme;

        }
    }

    public class BasicAuthenticationDefaults
    {
        public const string AuthenticationScheme = "Basic";
    }
}

