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

namespace PP3
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
            string manufacturer, name, image;

            manufacturer = txtM.Text;
            name = txtN.Text;
            image = txtI.Text;

            //validating if there is any empty spaces 
            if (string.IsNullOrEmpty(manufacturer)==true)
            {
                MessageBox.Show("Sorry that is an invalid Manufacturer");
            }
            if (string.IsNullOrEmpty(name)==true)
            {
                MessageBox.Show("Sorry that is an invalid Name");
            }
            double price;
            if (double.TryParse(txtP.Text,out price)==false)
            {
                MessageBox.Show("Sorry that is an invalid price");
            }
            if (string.IsNullOrEmpty(image)==true)
            {
                MessageBox.Show("Sorry that is an invalid image");
            }

            //overloaded constructor 
            Toys TT = new Toys()
            {
                Manufacturer = manufacturer,
                Name=name, 
                Price=price,
                Image=image
            };
            //adding it to the listbox

            lstBox.Items.Add(TT);

        }

        private void lstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //casting in the class 
            Toys selectedToy = (Toys)lstBox.SelectedItem;
            var uri = new Uri(selectedToy.Image);
            var img = new BitmapImage(uri);
            image.Source = img;

            MessageBox.Show($"{selectedToy.GetAisle()}");
        }
    }
}
