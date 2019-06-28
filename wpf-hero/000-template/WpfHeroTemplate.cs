using System;
using System.Windows;
using System.Windows.Controls;

namespace _000_template
{
    public class WpfHeroTemplate : Control
    {
        private readonly Type TypeofThis = typeof(WpfHeroTemplate);

        static WpfHeroTemplate()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(WpfHeroTemplate),
                new FrameworkPropertyMetadata(typeof(WpfHeroTemplate))
            );
        }
    }
}
