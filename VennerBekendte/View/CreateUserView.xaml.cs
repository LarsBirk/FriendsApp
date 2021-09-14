using System;
using System.Collections.Generic;
using System.Data;
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

namespace VennerBekendte.View
{
    /// <summary>
    /// Interaction logic for CreateUserView.xaml
    /// </summary>
    public partial class CreateUserView : Window
    {
        public CreateUserView()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=(local);Database=VennerBekendte;Trusted_Connection=Yes;"))

            {
                String query = "INSERT INTO users (username,password) VALUES (@username,@password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    
                    command.Parameters.AddWithValue("@username", UsernameInput.Text);
                    command.Parameters.AddWithValue("@password", ConfirmedPasswordInput.Password);
                    

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result == 1)
                    {
                        MessageBox.Show("Profile Has Been Saved");
                        Window1 window = new Window1();
                        window.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Profile Has NOT Been Saved");
                    }
                       
                }

            }











            //SqlConnection sqlCon = new SqlConnection(@"Server=(local);Database=VennerBekendte;Trusted_Connection=Yes;");
            //try
            //{
            //    if (sqlCon.State == ConnectionState.Closed) ;
            //    {
            //        sqlCon.Open();
            //    }

            //    string query = "INSERT into users (username,password) " +
            //        " VALUES ('" + UsernameInput.Text + "', '" + PasswordInput.Password + "');";

            //    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            //    sqlCmd.ExecuteNonQuery();

            //    sqlCmd.Parameters.AddWithValue("@Username", UsernameInput.Text);
            //    sqlCmd.Parameters.AddWithValue("@Password", ConfirmedPasswordInput.Password);
            //    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            //    if (count == 1)
            //    {
            //        MessageBox.Show("Profile has been saved");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Username or Password is incorrect");
            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    sqlCon.Close();
            //}
        }
    }
}
