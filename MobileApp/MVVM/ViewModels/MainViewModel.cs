using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MobileApp.MVVM.Models;
using MobileApp.MVVM.Views;

namespace MobileApp.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private ObservableCollection<ContactModel> contactModels = new ObservableCollection<ContactModel>();

        [RelayCommand]

        private void Add()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
                return; 
            ContactModels.Add(new ContactModel { FirstName = FirstName });
            FirstName = string.Empty;
        }

        [RelayCommand]

        private void Remove(ContactModel contact)
        {
            if (ContactModels.Contains(contact))
                ContactModels.Remove(contact);
        }
        [RelayCommand]

       private async Task Tap(ContactModel contact)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", new Dictionary<string, object>
            {
                { nameof(ContactModel), contact },
            });
        }
        //[RelayCommand]

        //private async Task Demo()
        //{
        //    await Shell.Current.GoToAsync(nameof(DetailsPage));
        //}

    }
}
