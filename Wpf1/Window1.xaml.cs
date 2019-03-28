using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Wpf1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : UserControl
    {

        public Window1()
        {
            InitializeComponent();
            
        }
        protected virtual void ListP_PreviewMouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            if (page.Children.GetType().Equals("AddPerson"))
                page.Children.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPerson addContact = new AddPerson();
            page.Children.Add(addContact);
    
            
            //page.Children.Clear();
        }

        private void Send (object sender, RoutedEventArgs e)
        {
            MessageBox.Clear();
        }

        private void ListP_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}