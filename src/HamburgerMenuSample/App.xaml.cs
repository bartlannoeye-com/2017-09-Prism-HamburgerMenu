using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using HamburgerMenuSample.Constants;
using Prism.Autofac.Windows;

namespace HamburgerMenuSample
{
    sealed partial class App : PrismAutofacApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(PageTokens.Main, null);
            return Task.CompletedTask;
        }
    }
}
