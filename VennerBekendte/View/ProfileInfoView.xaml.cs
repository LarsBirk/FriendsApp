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
    /// Interaction logic for ProfileInfoView.xaml
    /// </summary>
    public partial class ProfileInfoView : Window
    {
        public ProfileInfoView()
        {
            InitializeComponent();
        }

        private void CreateFriend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateFriend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserSettings_Click(object sender, RoutedEventArgs e)
        {

        }
        private void DeleteFriend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProfileInterestsListView.Items.Add(InterestInput.Text);
            ClearText();

        }

        private void ProfileInterestsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void ClearText()
        {
            InterestInput.Clear();
        }

        private void DeleteOneItem_Click(object sender, RoutedEventArgs e)
        {   
            if(ProfileInterestsListView.SelectedIndex == -1)
            {
                DeleteInterestErrorLabel.Visibility = Visibility.Visible;
            }
            if(ProfileInterestsListView.SelectedIndex > -1)
            {
                ProfileInterestsListView.Items.RemoveAt(ProfileInterestsListView.SelectedIndex);
                ClearText();
                DeleteInterestErrorLabel.Visibility = Visibility.Hidden;

            }
                 

        }

        private void DeleteAllItems_Click(object sender, RoutedEventArgs e)
        {
            ProfileInterestsListView.Items.Clear();
        }
        public void UpdateUserProfile()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in ProfileInterestsListView.Items)
            //for(int i = 0; i < ProfileInterestsListView.Items.Count; i++)
            {
                    sb.Append( item.ToString()+", ");
            }
            String test = sb.ToString();
            using (SqlConnection connection = new SqlConnection(@"Server=(local);Database=VennerBekendte;Trusted_Connection=Yes;"))
            {
                using (SqlCommand command = new SqlCommand("spUpdateUser", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", "Henrik"); //skal læse current user
                    command.Parameters.AddWithValue("@profilename", NameInput.Text);
                    command.Parameters.AddWithValue("@dob", DobInput.Text);
                    command.Parameters.AddWithValue("@email", EmailInput.Text);
                    command.Parameters.AddWithValue("@phonenumber", PhonenumberInput.Text);
                    command.Parameters.AddWithValue("@facebook", FacebookInput.Text);
                    command.Parameters.AddWithValue("@linkedin", LinkedinInput.Text);
                    command.Parameters.AddWithValue("@interests", test); // skal hente fra listview

                    connection.Open();
                    command.ExecuteNonQuery();
                   
                    MessageBox.Show("User has been updated");
                    
                }
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateUserProfile();
            
        }
    }
}
