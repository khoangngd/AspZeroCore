using kns.TourLand.Editions;
using kns.TourLand.Editions.Dto;
using kns.TourLand.MultiTenancy.Payments;
using kns.TourLand.Security;
using kns.TourLand.MultiTenancy.Payments.Dto;

namespace kns.TourLand.Web.Models.TenantRegistration
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
