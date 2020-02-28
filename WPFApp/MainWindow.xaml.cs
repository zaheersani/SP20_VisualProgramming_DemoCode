using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
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

        private void CalculationEvent(object sender, RoutedEventArgs e)
        {
            Button btnPressed = (Button)sender;
            if (btnPressed == this.btnSum)
                MessageBox.Show("Sum is clicked");
            if (btnPressed == this.btnMult)
                MessageBox.Show("Multiply is clicked");
            return;

            int num1, num2;
            if (int.TryParse(this.txtNum1.Text, out num1) 
                && int.TryParse(this.txtNum2.Text, out num2))
            {
                int sum = num1 + num2;
                MessageBox.Show(num1 + "+" + num2 + "=" + sum);
            } else
            {
                MessageBox.Show("Enter numbers only", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnNumInput(object sender, RoutedEventArgs e)
        {
            this.lblNums.Content = this.lblNums.Content.ToString() + ((Button)sender).Content;
        }
    }
}
