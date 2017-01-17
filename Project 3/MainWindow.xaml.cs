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

namespace Project_3
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
            long number = 600851475143;
            int count = 2;
            while (number != 1)
            {


                if (number % count == 0)
                {
                    number = (number / count);
                    
                    lstDisplay.Items.Add(count);
                }
                else
                {
                    count++;
                }
            }
            lblDisplay.Content = ("The largest prime factor is "+count);
        }
    }
}
