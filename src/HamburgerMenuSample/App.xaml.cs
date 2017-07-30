using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Autofac;
using HamburgerMenuSample.Constants;
using HamburgerMenuSample.Views;
using Prism.Autofac.Windows;

namespace HamburgerMenuSample
{
    sealed partial class App : PrismAutofacApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override UIElement CreateShell(Frame rootFrame)
        {
            var shell = Container.Resolve<ShellPage>();
            shell.SetContentFrame(rootFrame);
            return shell;
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(PageTokens.Main, null);
            return Task.CompletedTask;
        }
    }
}
