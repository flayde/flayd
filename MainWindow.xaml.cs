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

namespace flayd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddNumbers_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double result = num1 + num2;

            ResultLabel.Content = "Результат: " + result;
        }

        private void SubtractNumbers_Click(object sender, RoutedEventArgs e)
        {

            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double result = num1 - num2;

            ResultLabel.Content = "Результат: " + result;
        }

        private void MultiplyNumbers_Click(object sender, RoutedEventArgs e)
        {

            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double result = num1 * num2;

            ResultLabel.Content = "Результат: " + result;
        }
    }
}
