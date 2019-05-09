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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
namespace CarParts003
{
    /// <summary>
    /// Interaction logic for InstallWindow.xaml
    /// </summary>
    public partial class InstallWindow : MetroWindow
    {
        Page1 myFirstPage;
        public InstallWindow()
        {
            InitializeComponent();
            myFirstPage = new Page1();
            Main.Content = myFirstPage;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Button1.Content.ToString() == "Cancel")
            {
                this.Close();
            }

            if (Button1.Content.ToString() == "Previous")
            {
                Main.Content = myFirstPage;
                Button1.Content = "Cancel";
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
            Button1.Content = "Previous";
        }
    }
}
