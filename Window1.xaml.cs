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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void YourGotFocusEvent1(object sender, RoutedEventArgs e)
        {
            course1.Text = string.Empty;
            course1.GotFocus -= YourGotFocusEvent1;
        }

        public void YourGotFocusEvent2(object sender, RoutedEventArgs e)
        {
            course2.Text = string.Empty;
            course2.GotFocus -= YourGotFocusEvent2;
        }

        public void YourGotFocusEvent3(object sender, RoutedEventArgs e)
        {
            course3.Text = string.Empty;
            course3.GotFocus -= YourGotFocusEvent3;
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            MainWindow m_window = new MainWindow();
            m_window.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double marks1, marks2, marks3;

            marks1 = Convert.ToDouble(course1.Text);
            marks2 = Convert.ToDouble(course2.Text);
            marks3 = Convert.ToDouble(course3.Text);

            double courseAvg = (marks1 + marks2 + marks3) / 3;
            courseAvg = ((double)((int)((courseAvg + 0.005) * 100))) / 100; //just for better presentation for avg score
            avgScore.Text = courseAvg.ToString();

            if (courseAvg >= 90 && courseAvg <= 100)
            {
                grade.Text = "A";
            }

            if (courseAvg >= 80 && courseAvg < 90)
            {
                grade.Text = "B";
            }

            if (courseAvg >= 70 && courseAvg < 80)
            {
                grade.Text = "C";
            }

            if (courseAvg >= 60 && courseAvg < 70)
            {
                grade.Text = "D";
            }

            if (courseAvg >= 0 && courseAvg < 60)
            {
                grade.Text = "F";
            }

            if (courseAvg < 0 || courseAvg > 100)
            { 
                grade.Text = "not valid, please try again with marks between 0 and 100";
            }
        }
    }
}
