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
    public class NavTab
    {
        public string TabName { get; set; }
        public UIElement Tab { get; set; }
    }


    public partial class Navigation : UserControl
    {
        public Navigation(NavTab[] tabs = null)
        {
            InitializeComponent();
            if (tabs == null)
                return;
            foreach (var tab in tabs)
            {
                var _tab = new TabItem();
                _tab.Header = tab.TabName;
                _tab.Content = tab.Tab;
                Nav.Items.Add(_tab);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Art_txt.Text.Equals(string.Empty))
            {
                MessageBox.Show("Der Text ist nötig", "Fehler Meldung", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                //wenn alle Daten vorhanden sind wird der Vertrag hier generiert
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Art_txt.Text.Equals(string.Empty))
            {
                MessageBox.Show("Der Text ist nötig", "Fehler Meldung", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                //wenn alle Daten vorhanden sind wird der Vertrag hier generiert
            }
        }
    }
}
