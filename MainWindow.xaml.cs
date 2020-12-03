using System.Windows;

namespace Argb_Slider_bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel ViewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModel;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            ViewModel.AddColor();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.RemoveColor();
        }
    }
}
