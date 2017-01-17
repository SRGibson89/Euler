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

namespace Project_1
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

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;


            for (int counter = 1; counter < 1000; counter++)
            {

                if ((counter % 3 == 0) || (counter % 5 == 0))
                {
                    lstMulti.Items.Add(counter);
                    total = total + counter;
                }

            }

            lblSum.Content = ("the sum of all the multiples of 3 or 5 is " + total);
        }
    }
}
