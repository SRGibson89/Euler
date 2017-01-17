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

namespace Project_6
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
            int sq = 0, addsq = 0;
            for (int num = 1; num <= 100; num ++)
            {
                sq = (num * num);
                addsq = sq + addsq; 
            }

            int add = 0, sqadd = 0,count = 1;

            while (count <= 100)
            {
                add = count + add;
                count++;
                sqadd = (add * add);
                
            }
            int answer = (sqadd - addsq);
            
                lblDisplay.Content = ("The answer is " + answer);
        }
    }
}
