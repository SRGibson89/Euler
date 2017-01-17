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

namespace Project_7
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

        private static Boolean isPrime(int n)
        {
            if (n<= 1)
            {
                return false;
            }
            if (n<=3)
            {
                return true;
            }
            if ((n%2==0) || (n % 3 == 0))
            {
                return false;
            }
            int i = 5;
            while (i*i<=n)
            {
                if ((n%i==0) ||(n % (i+2) == 0))
                {
                    return false;

                }
                i = i + 6;
            }
            return true;
        }
        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            
            int prime = 0;
            
            int count = 0;
            for (count = 0; prime<10001 ;count++)
            {
                if (isPrime(count)==true)
                {
                    prime++;
                    
                }
            }
            lblDisplay.Content = (" The " + prime + "st Prime number is  " + (count-1));
        }
    }
}
