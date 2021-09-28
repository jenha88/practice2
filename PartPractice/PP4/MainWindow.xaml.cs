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
        private List<Contact> CC = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();

            var line = File.ReadAllLines("contacts.txt").Skip(1);
            foreach (var item in line)
            {
                CC.Add(new Contact(item));
            }
            foreach (var cc in CC)
            {
                
            }
        }
    }
}
