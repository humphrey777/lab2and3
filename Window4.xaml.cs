using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace lab2and3
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        public void YourGotFocusEvent8(object sender, RoutedEventArgs e)
        {
            speed.Text = string.Empty;
            speed.GotFocus -= YourGotFocusEvent8;
        }

        public void YourGotFocusEvent9(object sender, RoutedEventArgs e)
        {
            hour.Text = string.Empty;
            hour.GotFocus -= YourGotFocusEvent9;
        }

        private void Button_Click_back4(object sender, RoutedEventArgs e)
        {
            MainWindow m_window4 = new MainWindow();
            m_window4.Show();
            this.Close();
        }

        private string record()
        {
            String hourDistance ="";
            double spe = Convert.ToDouble(speed.Text);
            int time = Convert.ToInt16(hour.Text);
            for (int i = 1; i <= time; i++)
            {
                hourDistance = hourDistance+"\n"+(i.ToString() + "              " + (spe * i).ToString());
            }
            return hourDistance;
        }


        private void button_Click4(object sender, RoutedEventArgs e)
        {
            double spe = Convert.ToDouble(speed.Text);
            int time = Convert.ToInt16(hour.Text);
            double distance = spe * time;

            result.Text = "Hour        Distance Traveled" + record();
            totalDistance.Text = distance.ToString();
        }

    }


}

