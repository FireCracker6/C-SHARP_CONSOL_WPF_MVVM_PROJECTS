using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;

namespace WPF_APP_CONTACTS_MVVM.Services
{
    public static class ContactService 
    {
        static private ObservableCollection<ContactModel> contactList = new ObservableCollection<ContactModel>();

        public static ObservableCollection<ContactModel> ContactList { get { return Contacts;  }  set =>  contactList = Contacts; } 
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
            Debug.WriteLine(contact.Text);
            Debug.WriteLine(contactList.Count);
            //    ContactList.Add(contact);

        }

        public static void RemoveFromList(ContactModel contact)
        {
            Contacts.Remove(contact);
            FileService.SaveToFile(JsonConvert.SerializeObject(Contacts));
        }
        public static ObservableCollection<ContactModel> ContactList2()
        {

            var items = new ObservableCollection<ContactModel>();
            foreach (var contact in ContactList)
            {
                items.Add(contact);
            }
            return items;
        }


    }

}
