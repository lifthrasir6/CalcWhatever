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

namespace CalcWhatever
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
            int? num1 = Validator.ValidIsNumber(txtNum1.Text);
            int? num2 = Validator.ValidIsNumber(txtNum2.Text);

            if (num1 != null && num2 != null)
            {
                txtResult.Text = Calculate.Add((int)num1, (int)num2).ToString();
            }
            else
            {
                txtResult.Text = "Error";
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();

            int? num1 = Validator.ValidIsNumber(txtNum1.Text);
            int? num2 = Validator.ValidIsNumber(txtNum2.Text);

            if (num1 != null && num2 != null)
            {
                txtResult.Text = Calculate.Sub((int)num1, (int)num2).ToString();
            }
            else
            {
                txtResult.Text = "Error";
            }
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
            int? num1 = Validator.ValidIsNumber(txtNum1.Text);
            int? num2 = Validator.ValidIsNumber(txtNum2.Text);
            if (num1 != null && num2 != null)
            {
                txtResult.Text = Calculate.Multi((int)num1, (int)num2).ToString();
            }
            else
            {
                txtResult.Text = "Error";
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
            int? num1 = Validator.ValidIsNumber(txtNum1.Text);
            int? num2 = Validator.ValidIsNumber(txtNum2.Text);
            if (num1 != null && num2 != null && num2 != 0)
            {
                txtResult.Text = Calculate.Divide((int)num1, (int)num2).ToString();
            }
            else
            {
                txtResult.Text = "Error";
            }
        }
    }
}
