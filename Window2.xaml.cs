using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        public void YourGotFocusEvent4(object sender, RoutedEventArgs e)
        {
            numChecks.Text = string.Empty;
            numChecks.GotFocus -= YourGotFocusEvent4;
        }

        public void YourGotFocusEvent5(object sender, RoutedEventArgs e)
        {
            balance.Text = string.Empty;
            balance.GotFocus -= YourGotFocusEvent5;
        }

        private void Button_Click_back2(object sender, RoutedEventArgs e)
        {
            MainWindow m_window2 = new MainWindow();
            m_window2.Show();
            this.Close();
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            double bal = Convert.ToDouble(balance.Text);
            int numofchecks = Convert.ToInt16(numChecks.Text);
            double totalFee, checkFee, accountFee;
            totalFee = 0;
            checkFee = 0;
            accountFee = 0;

            if (bal < 400)
            {
                accountFee = 25;
            }

            else { accountFee = 15; }

            if (numofchecks < 20)
            {
                checkFee = 0.1 * numofchecks;
            }

            if (numofchecks >= 20 && numofchecks <= 39)
            {
                checkFee = 0.08 * numofchecks;
            }

            if (numofchecks >= 40 && numofchecks <= 59)
            {
                checkFee = 0.06 * numofchecks;
            }

            if (numofchecks >= 60)
            {
                checkFee = 0.04 * numofchecks;
            }

            totalFee = checkFee + accountFee;

            resultChecks.Text = numofchecks.ToString();
            resultBalance.Text = bal.ToString();
            serviceFee.Text = "$"+totalFee.ToString();
        }
    }


}
