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

namespace Project_4
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
            int num1 = 0, num2 = 0, sum = 0, paladrome = 0;
            string pala = " ", reversed = " ";

            for (num1 = 100; num1 <= 999; num1 ++)
            {
                for (num2 = 100; num2 <= 999; num2++ )
                {
                    sum = (num1 * num2);

                    pala = sum.ToString();
                    reversed = Reverse(pala);
                    
                    if (pala==reversed && sum > paladrome)
                    {
                        paladrome = sum;
                        lblDisplay.Content = ("The largest palandrome is " + num1 + "X" + num2 + "="+ pala );
                    }
                }
            }
            
            
        }
    
        public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
    }
    }
}
