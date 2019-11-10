using Microsoft.AspNet.Identity.EntityFramework;

namespace ServerWepApi
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("name=local")
        {

        }
    }
}