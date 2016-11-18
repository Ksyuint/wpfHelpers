using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfHelpers.WpfControls.Window
{
    public class TitleBarEx
    {
        private static UIElement _value = new UIElement();
        public static readonly DependencyProperty ButtonsInTitleBarProperty = DependencyProperty.RegisterAttached(
            "TitleAdditionalContent", typeof(UIElement), typeof(TitleBarEx), new PropertyMetadata(null));

        public static void SetTitleAdditionalContent(DependencyObject element, UIElement value)
        {
            element.SetValue(ButtonsInTitleBarProperty, value);
        }

        public static UIElement GetTitleAdditionalContent(DependencyObject element)
        {
            return (UIElement)element.GetValue(ButtonsInTitleBarProperty);
        }
    }
}
