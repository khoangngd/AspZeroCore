using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using tls.demo.Authorization.Users;
using tls.demo.MultiTenancy;

namespace tls.demo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}