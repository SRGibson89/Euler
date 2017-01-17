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

namespace Project_2
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

        private void btnGO_Click(object sender, RoutedEventArgs e)
        {
            long count = 1; //

            long number = 4000000, answer = 0, F1=0, F2 =1 , Sum = 0; //Varibles that will be used to find the fibonaci number

            while (answer<number)
            {
                answer = F1 + (F2);
                F2 = F1;
                F1 = answer;

                if (answer %2==0)
                {
                    lstFibbi.Items.Add(answer);
                    Sum = Sum + answer;
                    
                }

                count++;

            }
            lblSum.Content = ("The sum of the even values up to 4,000,000 is " + Sum);
        }
    }
}
