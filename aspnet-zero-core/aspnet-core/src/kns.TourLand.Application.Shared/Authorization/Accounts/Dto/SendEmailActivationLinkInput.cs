using System.ComponentModel.DataAnnotations;

namespace kns.TourLand.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}