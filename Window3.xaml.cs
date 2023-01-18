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
using System.Windows.Shapes;

namespace lab2and3
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        public void YourGotFocusEvent6(object sender, RoutedEventArgs e)
        {
            distance.Text = string.Empty;
            distance.GotFocus -= YourGotFocusEvent6;
        }

        public void YourGotFocusEvent7(object sender, RoutedEventArgs e)
        {
            weight.Text = string.Empty;
            weight.GotFocus -= YourGotFocusEvent7;
        }

        private void Button_Click_back3(object sender, RoutedEventArgs e)
        {
            MainWindow m_window3 = new MainWindow();
            m_window3.Show();
            this.Close();
        }

        private void button_Click3(object sender, RoutedEventArgs e)
        {
            double dis = Convert.ToDouble(distance.Text);
            double wei = Convert.ToDouble(weight.Text);
            double charges = 0;

            if (wei <= 2)
            {
                charges = 1.1 * Math.Ceiling(dis / 500);
            }

            if (wei > 2 && wei <= 6)
            {
                charges = 2.2 * Math.Ceiling(dis / 500);
            }

            if (wei > 6 && wei <= 10)
            {
                charges = 3.7 * Math.Ceiling(dis / 500);
            }

            if (wei > 10)
            {
                charges = 4.8 * Math.Ceiling(dis / 500);
            }

            resultDistance.Text = dis.ToString();
            resultWeight.Text = wei.ToString();
            charge.Text = "$"+charges.ToString();
        }
    }


}
