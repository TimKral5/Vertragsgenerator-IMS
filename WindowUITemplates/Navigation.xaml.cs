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

namespace WindowUITemplates
{
    /// <summary>
    /// Interaktionslogik für Navigation.xaml
    /// </summary>
    public partial class Navigation : UserControl
    {
        public Navigation()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("De Ben het en geili Muetter");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("De Jan het en geili Muetter");
        }
    }
}
