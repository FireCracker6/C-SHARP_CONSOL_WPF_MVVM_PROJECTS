using System;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
       // private readonly FileService fileService;
        public ContactModel SelectedItem { get; set; } = null!;


    

        [ObservableProperty]
        private string pageTitle = "Add Contacts";

        [ObservableProperty]
        private string contact = string.Empty;

        [RelayCommand]
        private void Add()
        {
           ContactService.AddToList(new ContactModel { Text = Contact });
            Contact = string.Empty;
        }
       

    }
}
