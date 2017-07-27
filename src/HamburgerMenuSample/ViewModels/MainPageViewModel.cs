using Prism.Windows.Mvvm;

namespace HamburgerMenuSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            DisplayText = "This is the main page!";
        }

        public string DisplayText { get; private set; }
    }
}