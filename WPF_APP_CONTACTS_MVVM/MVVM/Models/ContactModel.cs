using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using CommunityToolkit.Mvvm.Input;
using Prism.Commands;

namespace WPF_APP_CONTACTS_MVVM.MVVM.Models
{
    public partial class ContactModel 
    {




        private static int id = 1;
        static int GenerateId()
        {
            return id++;
        }

        public int Id { get; set; } = GenerateId();
        public Guid ContactId { get; set; } = Guid.NewGuid();
        public string ArtistName { get; set; } = string.Empty;
        public string Associates { get; set; } = string.Empty;
        public string RecordLabel { get; set; } = string.Empty;
        public string ArtistSongs { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
     
   

        public string DisplayName => $"{ArtistName} - {Associates}";



    }
}
