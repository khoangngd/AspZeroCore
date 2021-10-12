using tls.demo.Editions;
using tls.demo.Editions.Dto;
using tls.demo.MultiTenancy.Payments;
using tls.demo.Security;
using tls.demo.MultiTenancy.Payments.Dto;

namespace tls.demo.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
