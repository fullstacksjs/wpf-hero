using System.Windows;

namespace _001_searchbar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = $"WPF Hero - Searchbar D: (Height: {Height}, Width: {Width})";
            SizeChanged += (s, e) =>
            {
                Title = $"WPF Hero - Searchbar D: (Height: {Height}, Width: {Width})";
            };
        }
    }
}
