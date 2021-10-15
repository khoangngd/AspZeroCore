using System.Threading.Tasks;

namespace kns.TourLand.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}