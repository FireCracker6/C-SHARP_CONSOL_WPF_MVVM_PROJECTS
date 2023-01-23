using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;

namespace WPF_APP_CONTACTS_MVVM.Services
{
    public static class ContactService
    {
        public static ObservableCollection<ContactModel> Contacts { get; set; } = null!;

        static ContactService()
        {
            Contacts = new ObservableCollection<ContactModel>();
            FileService.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contacts.json";
        }

        public static void AddToList(ContactModel contact)
        {
            Contacts.Add(contact);
            FileService.SaveToFile(JsonConvert.SerializeObject(Contacts));
        }

        public static void RemoveFromList(ContactModel contact)
        {
            Contacts.Remove(contact);
            FileService.SaveToFile(JsonConvert.SerializeObject(Contacts));
        }


    }

}
