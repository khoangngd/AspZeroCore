using System.ComponentModel.DataAnnotations;

namespace tls.demo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
