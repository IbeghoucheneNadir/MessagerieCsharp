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

namespace Wpf1
{
    /// <summary>
    /// Logique d'interaction pour Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            // this.RemoveVisualChild(new Register());
            // this.RemoveLogicalChild(Wpf1.Register);
            // AddChild(new Window1());
            Window1 main = new Window1();
            NavigationService.Navigate(main);
            nom.Clear();
            password.Clear();
            password1.Clear();
        }
    }
}
