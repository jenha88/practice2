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

namespace PPP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            output.Visibility = Visibility.Hidden;
        }

        private void btb_Click(object sender, RoutedEventArgs e)
        {
            string first, last, birth;
            first = txtF.Text;
            last = txtL.Text;
            birth = txtBirth.Text;

            //calculating the date and time 
            DateTime date = Convert.ToDateTime(birth);
            TimeSpan age = DateTime.Now-date;
            int years = age.Days / 365;

            output.Content = $"Hello there {first} {last}! You are {years} years old!";
            output.Visibility = Visibility.Visible;

        }
    }
}
