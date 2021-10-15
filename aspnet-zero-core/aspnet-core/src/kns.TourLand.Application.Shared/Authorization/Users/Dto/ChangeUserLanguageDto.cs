using System.ComponentModel.DataAnnotations;

namespace kns.TourLand.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
