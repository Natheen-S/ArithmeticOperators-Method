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

namespace ArithmeticOperators_Method
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

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            int one = Convert.ToInt32(txtbox_one.Text);
            int two = Convert.ToInt32(txtbox_two.Text);
            int result = artithmeticoper(one,two);
            txtbox_three.Text= result.ToString();
        }

        private int artithmeticoper(int a, int b) 
        {
           
            int result = 0;
            if ( btn_plus.IsPressed ==true )
            {
                result = a + b;
                return result;
            }
            if (btn_minus.IsPressed ==true )
            {
                result = a - b;
                return result;
            }
            if ( btn_multiply.IsPressed ==true)
            {
                result = a * b;
                return result;
            }
            return result;
            
            
            
        }

    }
}
