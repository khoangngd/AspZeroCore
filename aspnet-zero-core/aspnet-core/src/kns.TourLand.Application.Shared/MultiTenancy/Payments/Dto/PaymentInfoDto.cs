using kns.TourLand.Editions.Dto;

namespace kns.TourLand.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < TourLandConsts.MinimumUpgradePaymentAmount;
        }
    }
}
