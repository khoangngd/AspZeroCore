using Xamarin.Forms;

namespace tls.demo.Views
{
    public partial class MainView : FlyoutPage, IXamarinView
    {
        public MainView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
