using System;
using System.Collections.Generic;
using System.IO;
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

namespace PP4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Contacts> CC = new List<Contacts>();
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("contact.txt").Skip(1);

            foreach (var item in lines)
            {
                CC.Add(new Contacts(item));
            }
        }

        private void lstbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
