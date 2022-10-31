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
using DNBSoft.WPF;

namespace WindowStyleTemplate
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class DarkWindow : Window
    {
        public DarkWindow(
            string title = "Application",
            UserControl content = null
            )
        {
            InitializeComponent();
            WindowResizer wr = new WindowResizer(this);
            wr.addResizerDown(ResizableBottom);
            wr.addResizerLeft(ResizableLeft);
            wr.addResizerRight(ResizableRight);
            wr.addResizerUp(ResizableTop);

            TitleLbl.Content = title;

            if (content != null)
            {
                ContentGrid.Children.Add(content);
            }
        }

        #region WindowHandler
        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
            => Close();

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
            => WindowState = WindowState.Minimized;

        private void DragBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point mouse = Mouse.GetPosition(this);
            if (WindowState != WindowState.Normal)
                WindowState = WindowState.Normal;
            DragMove();
        }



        #endregion
    }
}
