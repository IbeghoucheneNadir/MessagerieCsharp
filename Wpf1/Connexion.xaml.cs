using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Page
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            // this.RemoveVisualChild(new Register());
            // this.RemoveLogicalChild(Wpf1.Register);
            // AddChild(new Window1());
            // NavigationService.Navigate(new Uri("Register.xaml"));

            nom.Clear();
            password.Clear();
        }


        private void HandleLinkClick(object sender, RoutedEventArgs e)
        {



        }
    }
}
