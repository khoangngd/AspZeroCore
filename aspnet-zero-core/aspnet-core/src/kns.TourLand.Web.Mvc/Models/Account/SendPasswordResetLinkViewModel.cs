using System.ComponentModel.DataAnnotations;

namespace kns.TourLand.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}