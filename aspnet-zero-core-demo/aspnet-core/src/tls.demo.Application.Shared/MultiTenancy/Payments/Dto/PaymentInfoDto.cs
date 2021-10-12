using tls.demo.Editions.Dto;

namespace tls.demo.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < demoConsts.MinimumUpgradePaymentAmount;
        }
    }
}
