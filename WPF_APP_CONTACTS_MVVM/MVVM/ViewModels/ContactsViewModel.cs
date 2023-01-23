using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {



        public ContactsViewModel()
        {
            contacts = ContactService.Contacts;
        }

        [ObservableProperty]
        private string pageTitle = "Contacts";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts;
    }
}
