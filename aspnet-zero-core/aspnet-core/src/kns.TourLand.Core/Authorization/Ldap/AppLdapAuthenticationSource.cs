using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using kns.TourLand.Authorization.Users;
using kns.TourLand.MultiTenancy;

namespace kns.TourLand.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}