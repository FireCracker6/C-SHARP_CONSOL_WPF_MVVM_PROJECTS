using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Numerics;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP_CONTACTS_MVVM.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        [RelayCommand]
        private void GoToAddContact() => CurrentViewModel = new AddContactViewModel();


        [RelayCommand]
        private void GoToContacts() => CurrentViewModel = new ContactsViewModel();



        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel();
        }



    }
}
