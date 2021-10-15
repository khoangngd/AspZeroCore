using System.Threading.Tasks;
using kns.TourLand.Security.Recaptcha;

namespace kns.TourLand.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
