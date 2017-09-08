using Windows.UI.Xaml;
using Microsoft.Toolkit.Uwp.UI.Controls;

namespace HamburgerMenuSample.Control
{
    /// <summary> 
    /// The HamburgerMenuPrismItem provides an implementation for Prism navigation on HamburgerMenuGlyphItem.
    /// </summary> 
    public class HamburgerMenuPrismItem : HamburgerMenuGlyphItem
    {
        /// <summary> 
        /// Identifies the <see cref="TargetPageToken"/> dependency property. 
        /// </summary> 
        public static readonly DependencyProperty TargetPageTokenProperty = DependencyProperty.Register(nameof(TargetPageToken), typeof(string), typeof(HamburgerMenuPrismItem), new PropertyMetadata(null));

        /// <summary> 
        /// Gets or sets a value that specifies the page token to navigate to. 
        /// </summary> 
        public string TargetPageToken
        {
            get => (string)GetValue(TargetPageTokenProperty);
            set => SetValue(TargetPageTokenProperty, value);
        }
    }
}