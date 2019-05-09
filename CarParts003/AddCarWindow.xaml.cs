using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for AddCarWindow.xaml
    /// </summary>
    public partial class AddCarWindow : MetroWindow
    {
        
        public AddCarWindow()
        {
            InitializeComponent();
            dateTimePicker1.SelectedDate = DateTime.Today;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* string ConnectionString = @"Data Source=ATHLON\SQLEXPRESS;Initial catalog=CarParts;USER ID=sa;Password=loveneverdie";
            SqlConnection Connection;
            Connection = new SqlConnection(ConnectionString);
            try
            {
                Connection.Open();

                SqlCommand mySqlCommand;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DateTime myDateTime = dateTimePicker1.SelectedDate.Value;
                string SelectedDate = myDateTime.ToString("yyyy-MM-dd");

                string SQL = "INSERT INTO myCars (Name, Desc1, Desc2, Desc3, Desc4) values ('" + NameEditBox.Text+"',"+Desc1EditBox.Text+
                    ",'" + SelectedDate +"',";

                if (CheckBox1.IsChecked ?? false)
                {
                    SQL += "1,";
                }
                else
                {
                    SQL += "0,";
                }

                SQL += "'" + Desc4EditBox.Text + "')";

                MessageBox.Show(SQL);

                mySqlCommand = new SqlCommand(SQL, Connection);

                sqlDataAdapter.InsertCommand = new SqlCommand(SQL, Connection);

                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                mySqlCommand.Dispose();

                Connection.Close();
                
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
         
    */

        }

        private void DismissButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
