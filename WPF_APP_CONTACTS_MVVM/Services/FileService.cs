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



        public static string FilePath { get; set; } = string.Empty;

        public static string ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(FilePath);
                return sr.ReadToEnd();
            }
            catch { return string.Empty; }
        }


        public static void SaveToFile(string content)
        {
            using var sw = new StreamWriter(FilePath);
            sw.WriteLine(content);
        }
    }
}
