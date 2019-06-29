using System;
using System.Windows;
using System.Windows.Controls;

namespace _000_template
{
    public class WpfHeroTemplate : Control
    {
        private static readonly Type TypeofThis = typeof(WpfHeroTemplate);

        static WpfHeroTemplate()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(WpfHeroTemplate),
                new FrameworkPropertyMetadata(TypeofThis)
            );
        }

        /// <summary>
        /// Set or get the width of the base container in
        /// which the content resides.
        /// </summary>
        public double ContainerWidth
        {
            get => (double)GetValue(ContainerWidthProperty);
            set => SetValue(ContainerWidthProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ContainerWidth"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ContainerWidthProperty =
            DependencyProperty.Register(
                nameof(ContainerWidth),
                typeof(double),
                TypeofThis,
                new PropertyMetadata(400.0D)
            );

        /// <summary>
        /// Set or get the height of the base container in
        /// which the content resides.
        /// </summary>
        public double ContainerHeight
        {
            get => (double)GetValue(ContainerHeightProperty);
            set => SetValue(ContainerHeightProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ContainerHeight"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ContainerHeightProperty =
            DependencyProperty.Register(
                nameof(ContainerHeight),
                typeof(double),
                TypeofThis,
                new PropertyMetadata(400.0D)
            );
    }
}
