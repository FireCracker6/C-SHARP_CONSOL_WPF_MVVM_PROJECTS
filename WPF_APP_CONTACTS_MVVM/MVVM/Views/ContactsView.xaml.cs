using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using Prism.Commands;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.Views
{
    /// <summary>
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {
        private static ObservableCollection<ContactModel> _contacts;
        private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\artists.json");
        public ContactsView()

        {
            InitializeComponent();
        

        }


        
        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;

            _contactEditDetails.Visibility = Visibility.Hidden;
            
            contact.ArtistName = fName.Text;
            contact.Associates = _assoc.Text;
            contact.RecordLabel = _record.Text;
           ContactService.RemoveFromList(contact);
          ContactService.AddToList(contact);
          //  ContactService.UpdateArtist(contact);
            try
            {
                _contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(fileService.Read())!;

            }
            catch { _contacts = new ObservableCollection<ContactModel>(); }
          //  ObservableCollection<ContactModel> items = new ObservableCollection<ContactModel>();
            _view.ItemsSource = _contacts;

        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;
            ContactService.RemoveFromList(contact);
        }

        private void _view_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Double Click once , and then click on artist in list to see and edit artist details
            _contactDetails.Visibility = Visibility.Visible;
            _contactEditDetails.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btn_EditDetails_Click(object sender, RoutedEventArgs e)
        {
            _contactEditDetails.Visibility = Visibility.Visible;
            _contactDetails.Visibility = Visibility.Hidden;
        }
    }

}
