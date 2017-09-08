using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using HamburgerMenuSample.Constants;
using HamburgerMenuSample.Control;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Windows.Navigation;

namespace HamburgerMenuSample.ViewModels
{
    internal class ShellViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ShellViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            MenuItemClicked = new DelegateCommand<ItemClickEventArgs>(OnMenuItemClicked);
            OptionItemClicked = new DelegateCommand<ItemClickEventArgs>(OnMenuItemClicked);

            LoadNavigationItems();
        }

        private ObservableCollection<HamburgerMenuItem> _menuItems;
        public ObservableCollection<HamburgerMenuItem> MenuItems
        {
            get => _menuItems;
            set => SetProperty(ref _menuItems, value);
        }

        private ObservableCollection<HamburgerMenuItem> _optionItems;
        public ObservableCollection<HamburgerMenuItem> OptionItems
        {
            get => _optionItems;
            set => SetProperty(ref _optionItems, value);
        }

        public DelegateCommand<ItemClickEventArgs> MenuItemClicked { get; }

        public DelegateCommand<ItemClickEventArgs> OptionItemClicked { get; }

        private void OnMenuItemClicked(ItemClickEventArgs args)
        {
            HamburgerMenuPrismItem menuItem = (HamburgerMenuPrismItem)args.ClickedItem;
            _navigationService.Navigate(menuItem.TargetPageToken, null);
        }

        private void LoadNavigationItems()
        {
            MenuItems = new ObservableCollection<HamburgerMenuItem>();
            MenuItems.Add(new HamburgerMenuPrismItem {Label = "Main", TargetPageToken = PageTokens.MainPage});
            MenuItems.Add(new HamburgerMenuPrismItem {Label = "Second", TargetPageToken = PageTokens.SecondPage});
            MenuItems.Add(new HamburgerMenuGlyphItem { Label = "Order Detail" });
            MenuItems.Add(new HamburgerMenuGlyphItem { Label = "Payment" });

            OptionItems = new ObservableCollection<HamburgerMenuItem>();
            OptionItems.Add(new HamburgerMenuGlyphItem { Label = "About" });
        }
    }
}
