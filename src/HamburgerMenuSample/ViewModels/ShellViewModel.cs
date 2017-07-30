using System.Collections.ObjectModel;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Prism.Mvvm;

namespace HamburgerMenuSample.ViewModels
{
    internal class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {
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

        private void LoadNavigationItems()
        {
            MenuItems = new ObservableCollection<HamburgerMenuItem>();
            MenuItems.Add(new HamburgerMenuGlyphItem { Label = "Account" });
            MenuItems.Add(new HamburgerMenuGlyphItem { Label = "Order" });
            MenuItems.Add(new HamburgerMenuGlyphItem { Label = "Order Detail" });
            MenuItems.Add(new HamburgerMenuGlyphItem { Label = "Payment" });

            OptionItems = new ObservableCollection<HamburgerMenuItem>();
            OptionItems.Add(new HamburgerMenuGlyphItem { Label = "About" });
        }
    }
}
