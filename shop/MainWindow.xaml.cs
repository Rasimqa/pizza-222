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
using System.Collections.Generic;

namespace shop
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
        List<string> pizza = new List<string>() { "Margarita" };
        List<string> pizzacard = new List<string>() { "Gribnaya", "Myasnaya", "Cheese", "Foursezone" };

        private void Button_Click_AddCard(object sender, RoutedEventArgs e)
        {
            if (AddPiz.Text == "Gribnaya")
            {
                pizza1.Opacity = 1;
                pizza1_name.Opacity = 1;
                pizza1_price.Opacity = 1;
                pizza1_text.Opacity = 1;
                IMG1.Opacity = 1;
                IMG1.Source = new BitmapImage(new Uri("/IMG/gribi.png", UriKind.Relative));
                pizza1_name.Text = "Gribnaya";
                pizza1_price.Text = "Price: 14$\r\n";
                pizza1_text.Text = "This good pizza";
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
