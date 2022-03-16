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

namespace AppVariasPaginas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Login pageLogin = new Login();
        private AcercaDe pageAcercaDe = new AcercaDe();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(pageLogin);
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(pageAcercaDe);
        }
    }
}
