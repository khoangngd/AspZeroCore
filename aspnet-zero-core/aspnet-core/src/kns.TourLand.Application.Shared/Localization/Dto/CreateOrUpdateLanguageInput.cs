using System.ComponentModel.DataAnnotations;

namespace kns.TourLand.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}