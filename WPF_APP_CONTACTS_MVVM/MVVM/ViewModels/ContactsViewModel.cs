using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
      
        [ObservableProperty]
        private string pageTitle = "Artists & Associates";

        [ObservableProperty]
        private ObservableCollection<ContactModel> contacts = ContactService.Contacts();

    }
}
