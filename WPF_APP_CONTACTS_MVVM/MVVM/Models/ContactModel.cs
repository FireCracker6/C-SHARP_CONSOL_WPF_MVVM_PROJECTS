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

       


       
       
        public Guid ContactId { get; set; } = Guid.NewGuid();
        public string ArtistName { get; set; } = string.Empty;
        public string Associates { get; set; } = string.Empty;
        public string RecordLabel { get; set; } = string.Empty;
        public string ArtistSongs { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
       public  List<ArtistSongsRecorded> ArtistSongsRecorded { get; set; } = new List<ArtistSongsRecorded>();

        public string DisplayName => $"{ArtistName} - {Associates}";



    }
}
