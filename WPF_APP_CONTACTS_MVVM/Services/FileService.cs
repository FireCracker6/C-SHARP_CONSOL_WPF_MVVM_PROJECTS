using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;

namespace WPF_APP_CONTACTS_MVVM.Services
{
    public static class FileService
    {
        private static List<ContactModel> todos;
        public static ObservableCollection<ContactModel> contactList { get; set; } = null!;

        public static string FilePath { get; set; } = string.Empty;


       
        private static void ReadFromFile()
        {
            try
            {

                using var sr = new StreamReader(FilePath);
                todos = JsonConvert.DeserializeObject<List<ContactModel>>(sr.ReadToEnd())!;
            }
            catch { todos = new List<ContactModel>(); }
        }

        public static void SaveToFile(string content)
        {
            using var sw = new StreamWriter(FilePath);
            sw.WriteLine(content);
        }

        public static ObservableCollection<ContactModel> ContactList2()
        {
            var items = new ObservableCollection<ContactModel>();
            foreach (var contact in contactList)
            {
                items.Add(contact);
            }
            return items;
        }
    }
}
