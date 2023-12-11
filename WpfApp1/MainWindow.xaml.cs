using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
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
        public int a, b, c, a1, b1, c1;

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Triad triad = new Triad();
            triad.SetParams(a1, b1, c1, true);
            triad.Result(out a, out b, out c);
            d.Text = Convert.ToString(a);
            e_tb.Text = Convert.ToString(b);
            f.Text = Convert.ToString(c);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            

            Triad triad = new Triad();

            a1 = Convert.ToInt32(a_tb.Text);
            b1 = Convert.ToInt32(b_tb.Text);
            c1 = Convert.ToInt32(c_tb.Text);

            triad.SetParams(a1, b1, c1);

            triad.Result(out a, out b, out c);

            

            d.Text = Convert.ToString(a);
            e_tb.Text = Convert.ToString(b);
            f.Text = Convert.ToString(c);
         
            
        }

        
    }
}
