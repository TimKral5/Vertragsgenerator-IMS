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
using WindowUITemplates;

namespace Vertragsgenerator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Navigation nav = new Navigation();
            

            DarkWindow window = new DarkWindow(
                title: "Vertragsgenerator",
                content: nav
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
