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
using PizzaSplit.Core;
namespace PizzaSplit.WpfApp
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

        private void CalculateButton_click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PeopleTextBox.Text))
            {
                MessageBox.Show("Please enter a number of people");
                return;
            }

            if (!int.TryParse(PeopleTextBox.Text, out int people))
            {
                MessageBox.Show("Please enter a valid number of people");
                return;
            }

            if (people < 1 || people > 20)
            {
                MessageBox.Show("Max number of people is 1 to 20");
                return;
            }

            if (string.IsNullOrWhiteSpace(AmountTextBox.Text))
            {
                MessageBox.Show("Please enter an amount");
                return;
            }

            if (!double.TryParse(AmountTextBox.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid amount");
                return;
            }

            if (amount < 0 || amount >= 10000)
            {
                MessageBox.Show("Max amount is 0 < amount <= 10000");
                return;
            }

            bool tips = TipCheckBox.IsChecked == true;

            double result = BillCalculator.Calculate(people, amount, tips);

            ResultTextBox.Text = result.ToString("F2");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            PeopleTextBox.Clear();
            AmountTextBox.Clear();
            ResultTextBox.Clear();

            TipCheckBox.IsChecked = false;

            ResultTextBox.Focus(); 

        }
    }
}