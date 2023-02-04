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
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Commands;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.Views
{
    /// <summary>
    /// Doubleclick once in the list to show artist details, and update the artist information.
    /// </summary>
    public partial class ContactsView : UserControl
    {


        public ContactsView()

        {
            InitializeComponent();


        }



        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;

            _contactDetails.Visibility = Visibility.Visible;


            contact.ArtistName = fName.Text;
            contact.Associates = _assoc.Text;
            contact.RecordLabel = _record.Text;
            ContactService.RemoveFromList(contact);
            ContactService.AddToList(contact);

        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;
            ContactService.RemoveFromList(contact);
        }

        private void _view_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _contactDetails.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

}