using System;

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;

namespace WPF_APP_CONTACTS_MVVM.Services
{
    public static class ContactService
    {

        //private static readonly FileService fileService ;
        private static ObservableCollection<ContactModel> contacts;


        private static readonly FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contacts.json");


        static ContactService()
        {
            try
            {
                contacts = JsonConvert.DeserializeObject<ObservableCollection<ContactModel>>(fileService.Read())!;

            }
            catch { contacts = new ObservableCollection<ContactModel>(); }
        }



        public static void AddToList(ContactModel model)
        {
            contacts.Add(model);
            
            Debug.WriteLine(model.ArtistName);
            fileService.Save(JsonConvert.SerializeObject(contacts));

        }

        public static void RemoveFromList(ContactModel model)
        {
            contacts.Remove(model);
            fileService.Save(JsonConvert.SerializeObject(contacts));
        }


        public static ObservableCollection<ContactModel> Contacts()
        {
            return contacts;
        }



        private static ContactModel instance = new ContactModel();

        public static ContactModel Instance { get { return instance; } }
        public static void ShowList()
        {
            Debug.WriteLine(instance.ContactId);
        }

    }
}
