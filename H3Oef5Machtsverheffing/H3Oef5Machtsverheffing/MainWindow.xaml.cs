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

namespace H3Oef5Machtsverheffing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Text = "1";
            resultTextBox.Clear();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int number;
            string inputNumber = numberTextBox.Text;

            bool isValidNumber = int.TryParse(inputNumber, out number);

            if (isValidNumber)
            {
                if (number <= 84)
                {
                    resultTextBox.Text = $@"1ste macht van {number} = {Math.Pow(number,1)}
2de macht van {number} = {Math.Pow(number, 2)}
3de macht van {number} = {Math.Pow(number, 3)}
4de macht van {number} = {Math.Pow(number, 4)}
5de macht van {number} = {Math.Pow(number, 5)}
6de macht van {number} = {Math.Pow(number, 6)}
7de macht van {number} = {Math.Pow(number, 7)}
8ste macht van {number} = {Math.Pow(number, 8)}
9de macht van {number} = {Math.Pow(number, 9)}
10de macht van {number} = {Math.Pow(number, 10)}";
                }
                else
                {
                    resultTextBox.Text = "Geef een getal lager dan 84 in";
                }
            }
            else
            {
                resultTextBox.Text = "Geef een correct getal in";
            }
        }
    }
}