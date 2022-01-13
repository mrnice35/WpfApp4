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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate1.Text);
            double sumEvro = Convert.ToDouble(sum1.Text);
            double resDouble1= rateEvro * sumEvro;
            resSum1.Text = resDouble1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateGrivna * sumGrivna;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDrama * sumDrama;
            resSum3.Text = resDouble3.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInch= Convert.ToDouble(rate4.Text);
            double resDouble4 = rateInch * 0.0254;
            resSum4.Text = resDouble4.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFut = Convert.ToDouble(rate5.Text);
            double resDouble5 = rateFut * 0.3048;
            resSum5.Text = resDouble5.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMil = Convert.ToDouble(rate6.Text);
            double resDouble6 = rateMil * 1609.344;
            resSum6.Text = resDouble6.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rate7.Text);
            double resDouble7 = rateVerst * 1066.8;
            resSum7.Text = resDouble7.ToString();
        }
    }
}
