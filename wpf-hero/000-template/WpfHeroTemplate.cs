using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace _000_template
{
    /// <summary>
    /// Base class for <c>000-template project</c>.
    /// <para/>
    /// This class contains the basic logic for simplified
    /// creating the <c>challenges projects</c>.
    /// <para/>
    /// This class is inherited from the <see cref="Control"/> class.
    /// <para/>
    /// This <c>Expander ui-element</c> is not affiliated with
    /// the any Design guidelines!
    /// <para/>
    /// This ui-element was created in accordance with
    /// one of the projects full-stacks github organization:
    /// https://github.com/full-stacks/css-hero.
    /// </summary>
    [ContentProperty("Content")]
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
        /// Set or get the content object that was set in the
        /// tags of the Expander ui-element.
        /// 
        /// <para>Designer Category: <c>Common</c>.</para>
        /// </summary>
        [Category("Common")]
        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Content"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register(
                nameof(Content),
                typeof(object),
                TypeofThis,
                null
            );

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
