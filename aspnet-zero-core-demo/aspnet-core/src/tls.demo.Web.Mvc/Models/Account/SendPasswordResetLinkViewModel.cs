using System.ComponentModel.DataAnnotations;

namespace tls.demo.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}