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

namespace SoChanSoLe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nhap = 0;
        int tongday = 0;
        int tongchan = 0;
        int tongle = 0;
        int s = 0;
        int n;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int nhap = Convert.ToInt32(txtn.Text);
            int tongday = 0;
            int tongchan = 0;
            int tongle = 0;

            if (r1.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                {
                    tongday = tongday + i;
                }
                txtkq1.Text = tongday.ToString();
            }
            if (rchan.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                    if (i % 2 == 0)
                    {
                        tongchan += i;
                        txtkq2.Text = tongchan.ToString();
                    }
            }
            if (rle.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                    if (i % 2 != 0)
                    {
                        tongle += i;
                        txtkq3.Text = tongle.ToString();
                    }
            }
        }

        private void R1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Rchan_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Rle_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
