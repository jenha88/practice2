
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

namespace PP2
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

        private void btb_Click(object sender, RoutedEventArgs e)
        {
            lstC.Items.Clear();
            lstV.Items.Clear();

            string word;

            word = txtbox.Text;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a'|| word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' )
                {
                    lstV.Items.Add(word[i]);
                }
                else
                {
                    lstC.Items.Add(word[i]);
                }
            }

            txtbox.Clear();
        }
                
    }
}
