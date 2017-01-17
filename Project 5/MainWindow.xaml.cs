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

namespace Project_5
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
            int s = 11;
            Boolean all = false ;

            do
            {
                Boolean one = false, two = false, three = false, four = false, five = false, six = false,
                    seven = false, eight = false, nine = false, ten = false, eleven = false, twelve = false, threet = false, fourt = false
                    , fivet = false, sixt = false, sevent = false, eightt = false, ninet = false, twenty = false;
                if (s % 1 == 0)
                    one = true;
                else
                {
                    s++;
                }
                if (s % 2 == 0)
                    two = true;
                else
                {
                    s++;
                }
                if (s % 3 == 0)
                    three = true;
                else
                {
                    s++;
                }
                if (s % 4 == 0)
                    four = true;
                else
                {
                    s++;
                }
                if (s % 5 == 0)
                    five = true;
                else
                {
                    s++;
                } if (s % 6 == 0)
                    six = true;
                else
                {
                    s++;
                }
                if (s % 7 == 0)
                    seven = true;
                else
                {
                    s++;
                }
                if (s % 8 == 0)
                    eight = true;
                else
                {
                    s++;
                }
                if (s % 9 == 0)
                    nine = true;
                else
                {
                    s++;
                } 
                if (s % 10 == 0)
                    ten = true;
                else
                {
                    s++;
                }
                if (s % 11 == 0)
                    eleven = true;
                else
                {
                    s++;
                }
                if (s % 12 == 0)
                    twelve = true;
                else
                {
                    s++;
                }
                if (s % 13 == 0)
                    threet = true;
                else
                {
                    s++;
                }
                if (s % 14 == 0)
                    fourt = true;
                else
                {
                    s++;
                }
                if (s % 15 == 0)
                    fivet = true;
                else
                {
                    s++;
                }
                if (s % 16 == 0)
                    sixt = true;
                else
                {
                    s++;
                }
                if (s % 17 == 0)
                    sevent = true;
                else
                {
                    s++;
                }
                if (s % 18 == 0)
                    eightt = true;
                else
                {
                    s++;
                }
                if (s % 19 == 0)
                    ninet = true;
                else
                {
                    s++;
                }
                if (s % 20 == 0)
                    twenty = true;
                else
                {
                    s++;
                }

                if (one ==true && two ==true && three == true && four ==true && five ==true && six ==true && seven ==true && eight ==true
                    && nine == true && ten == true && eleven == true && twelve == true && threet == true && fourt == true
                    && fivet == true && sixt == true && sevent == true && eightt == true && ninet == true && twenty == true)
                    all = true;
               

            }
            while (all == false);
            lblDisplay.Content = ("the smallest number is " + s);
        }
    }
}
