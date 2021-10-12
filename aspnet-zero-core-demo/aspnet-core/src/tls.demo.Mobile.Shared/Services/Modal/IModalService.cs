using System.Threading.Tasks;
using tls.demo.Views;
using Xamarin.Forms;

namespace tls.demo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
