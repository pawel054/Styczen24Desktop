using System.IO;
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

namespace AplikacjaDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string eyesColor = "niebieskie";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateImages(object sender, RoutedEventArgs e)
        {
            try
            {
                imgPerson.Source = new BitmapImage(new Uri($"pack://application:,,,/AplikacjaDesktop;component/Images/{txtNumber.Text}-zdjecie.jpg"));
                imgFingerPrint.Source = new BitmapImage(new Uri($"pack://application:,,,/AplikacjaDesktop;component/Images/{txtNumber.Text}-odcisk.jpg"));
            }
            catch{}
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show($"{txtName.Text} {txtSurname.Text} kolor oczu {eyesColor}");
            }
            else if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Wprowadź dane");
            }
        }

        private void ChooseEyeColor(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            eyesColor = radioButton.Content.ToString();
        }
    }
}