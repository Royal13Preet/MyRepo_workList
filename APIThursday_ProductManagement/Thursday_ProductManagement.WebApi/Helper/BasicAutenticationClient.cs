using System.Security.Principal;

namespace Thursday_ProductManagement.WebApi.Helper
{
    public class BasicAutenticationClient : IIdentity
    {
        public string? AuthenticationType { get; set; }

        public bool IsAuthenticated { get; set; }

        public string? Name { get; set; }
    }
}
