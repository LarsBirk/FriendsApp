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
    }
}
