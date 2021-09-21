using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VennerBekendte.Data
{
    class SqlData
    {
        /*
         * move all data classes to this folder.
        */

        public void CheckIfUserExist(String Username,)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=(local);Database=VennerBekendte;Trusted_Connection=Yes;"))
            {
                using (SqlCommand command = new SqlCommand("spUserExistCheck", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", UsernameInput.Text);

                    connection.Open();
                    int status = Convert.ToInt32(command.ExecuteScalar());

                    if (status == 1)
                    {
                        MessageBox.Show("Username already Exist");
                    }
                    else
                    {
                        if (PasswordInput.Password == ConfirmedPasswordInput.Password && UsernameInput.Text.Length > 0)
                        {
                            using (SqlConnection connection2 = new SqlConnection(@"Server=(local);Database=VennerBekendte;Trusted_Connection=Yes;"))
                            {

                                using (SqlCommand cmdCreate = new SqlCommand("spCreateNewUser", connection2))
                                {
                                    cmdCreate.CommandType = CommandType.StoredProcedure;
                                    cmdCreate.Parameters.AddWithValue("@username", UsernameInput.Text);
                                    cmdCreate.Parameters.AddWithValue("@password", ConfirmedPasswordInput.Password);

                                    connection2.Open();
                                    int result = cmdCreate.ExecuteNonQuery(); // skal være her ellers udføres creation ikke.

                                }
                            }
                        }
                      
                    }
                }
               
            }
        }

        public void CreateNewUser()
        {
            using (SqlConnection connection2 = new SqlConnection(@"Server=(local);Database=VennerBekendte;Trusted_Connection=Yes;"))
            {

                using (SqlCommand cmdCreate = new SqlCommand("spCreateNewUser", connection2))
                {
                    cmdCreate.CommandType = CommandType.StoredProcedure;
                    cmdCreate.Parameters.AddWithValue("@username", UsernameInput.Text);
                    cmdCreate.Parameters.AddWithValue("@password", ConfirmedPasswordInput.Password);

                    connection2.Open();
                    int result = cmdCreate.ExecuteNonQuery(); // skal være her ellers udføres creation ikke.

                    MessageBox.Show("User created!");
                    Window1 window = new Window1();
                    window.Show();
                    this.Close();
                }
            }
        }
    }
}
