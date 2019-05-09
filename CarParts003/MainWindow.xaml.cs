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
using MahApps.Metro.Controls;

namespace CarParts003
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyControlTab.SelectedIndex = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyControlTab.SelectedIndex = 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyControlTab.SelectedIndex = 0;
        }

        private void AddcarListItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MyControlTab.SelectedIndex = 1;
        }

        private void AddPartListItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MyControlTab.SelectedIndex = 2;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InstallTabControl.SelectedIndex = 0;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InstallTabControl.SelectedIndex = 1;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MyControlTab.SelectedIndex = 3;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MyControlTab.SelectedIndex = 4;
        }

        private void Install_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MyControlTab.SelectedIndex = 3;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MyControlTab.SelectedIndex = 4;
        }

        private void StackPanel_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MyControlTab.SelectedIndex = 5;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MyControlTab.SelectedIndex = 0;
            }
        }
    }
}
