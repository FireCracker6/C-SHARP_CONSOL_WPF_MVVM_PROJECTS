using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artist_APP_MVVM.Services;
using System.Windows.Input;
using Artist_APP_MVVM.Helpers;
using Artist_APP_MVVM.MVVM.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Artist_APP_MVVM.MVVM.ViewModels
{
    internal class AddArtistViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly ArtistService _artistService;
        private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\artistsNew.json");

        private static ObservableCollection<ArtistModel> artists  = new ObservableCollection<ArtistModel>();
        public ICommand AddCommand { get; }
        //public ICommand RemoveCommand { get; }
        public ICommand CancelCommand { get; }
        public ArtistModel Artist { get; set; }  = new ArtistModel();

        public AddArtistViewModel(NavigationStore navigationStore, ArtistService artistService)
        {
            _navigationStore = navigationStore;
            _artistService = artistService;
          
            AddCommand = AddArtist();
            CancelCommand = Cancel();

            try
            {
                artists = JsonConvert.DeserializeObject<ObservableCollection<ArtistModel>>(fileService.Read())!;

            }
            catch { artists = new ObservableCollection<ArtistModel>(); }

        }


        public string ArtistName { get; set; } = "Nikki Sixx";
        public string Associates { get; set; } = "Mötley Crüe";
        public string RecordLabel { get; set; } = "Nuclear Blast";
        public string ArtistSong { get; set; } = "Looks That Kill";

       

        private ICommand AddArtist()
        {
         
          Artist = new ArtistModel  {  ArtistName = ArtistName, Associates = Associates, RecordLabel = RecordLabel, ArtistSongs = ArtistSong};
            ArtistService.AddToList(Artist);
            artists.Add(Artist);
            fileService.Save(JsonConvert.SerializeObject(artists));
            Debug.WriteLine( Artist.ArtistName);
            ArtistService.AddToList(Artist);

            return new NavigateCommand<AddArtistViewModel>(_navigationStore, () => new AddArtistViewModel(_navigationStore, _artistService));

        }
        private ICommand Cancel()
        {
            Artist = new ArtistModel();
            return new NavigateCommand<ArtistsViewModel>(_navigationStore, () => new ArtistsViewModel(_navigationStore, _artistService));

        }



    }
}
