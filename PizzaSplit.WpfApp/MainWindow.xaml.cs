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
            
            int people = int.Parse(PeopleTextBox.Text);

            if (people < 1 || people > 20)
            {
                MessageBox.Show("Max number of people is 1 to 20");
                return;
            }

            double amount = double.Parse(AmountTextBox.Text);
            
            if (amount < 0 || amount >= 10000)
            {
                MessageBox.Show("Max amount is 0 < amount <= 10000");
                return;
            }

            bool tips = TipCheckBox.IsChecked == true;

            BillCalculator calculator = new BillCalculator();

            double result = calculator.Calculate(people, amount, tips);

            ResultTextBox.Text = result.ToString();
        }
    }
}