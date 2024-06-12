using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearnWpfSuiteTransition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetImage(0);
        }

        private int _currentImageIndex = 0;

        private ImageSource[] _imageSources = new[]
        {
            new BitmapImage(new Uri("pack://application:,,,/Assets/1.jpg")),
            new BitmapImage(new Uri("pack://application:,,,/Assets/2.jpg")),
            new BitmapImage(new Uri("pack://application:,,,/Assets/3.jpg")),
        };

        private void SetImage(int index)
        {
            transitioningContentControl.Content = new Image()
            {
                Source = _imageSources[index],
                Width = 300,
                Stretch = Stretch.UniformToFill
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _currentImageIndex = (_currentImageIndex + 1) % _imageSources.Length;
            SetImage(_currentImageIndex);
        }
    }
}