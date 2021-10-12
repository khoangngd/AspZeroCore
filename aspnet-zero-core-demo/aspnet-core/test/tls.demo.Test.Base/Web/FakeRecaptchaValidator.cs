using System.Threading.Tasks;
using tls.demo.Security.Recaptcha;

namespace tls.demo.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
