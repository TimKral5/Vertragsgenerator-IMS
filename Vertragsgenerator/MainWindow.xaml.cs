﻿using System;
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
using WindowStyleTemplate;

namespace Vertragsgenerator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DarkWindow window = new DarkWindow(
                title: "Vertragsgenerator",
                content: new Grid { Background = new SolidColorBrush(Color.FromRgb(255,0,0)), Name="test" }
                );
            window.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new DarkWindow().Show();
        }
    }
}
