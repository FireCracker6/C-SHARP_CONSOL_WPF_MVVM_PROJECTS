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
    /// Interaction logic for ContactsView.xaml
    /// </summary>
    public partial class ContactsView : UserControl
    {


        public ContactsView()

        {
            InitializeComponent();
        

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var button = (Button)sender;
            var contact = (
                ContactModel)button.DataContext;
            Debug.WriteLine(contact);
            ContactService.RemoveFromList(contact);
            //  Guid context1 = (Guid)contact;
            // Guid contextRemove = context1;
            //Debug.WriteLine(context1);
            Debug.WriteLine(contact);
            //foreach(ContactModel contact in contacts)
            //{
            //    Debug.WriteLine(contact.Text);
            //  var c =  contacts.Find(x => contact.ContactId == context1);
            //    Debug.WriteLine(c);

            //}
            //  var b = contacts.Find(x => x.ContactId == context1);
            // Debug.WriteLine(b);
            // if (SelectedPlayer.ContactId == context1)
            //  contacts.Remove((ContactModel)contacts.Where(x => x.ContactId == context1));
            // var contactSelected = contacts.Find(x => x.ContactId == context1);
            // Debug.WriteLine(contactSelected);

            //  if (context != null)
            //  contacts.Remove((ContactModel)Selection.Where(x => x.ContactId == context1));
            // contacts.Remove(SelectedPlayer);
            // SelectedCustomer = null!;
            // fileService.Remove(itemRemove);
            //    Debug.WriteLine(_SelectedPlayer.Text);

        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;

            
           
            contact.FirstName = fName.Text;
            ContactService.RemoveFromList(contact);
            ContactService.AddToList(contact);

        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var contact = (ContactModel)button.DataContext;
            ContactService.RemoveFromList(contact);
        }
    }

}
