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

namespace Artist_APP_MVVM.MVVM.ViewModels
{
    internal class AddArtistViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly ArtistService _artistService;

        public ICommand AddCommand { get; }
        //public ICommand RemoveCommand { get; }
        public ICommand CancelCommand { get; }
        public ArtistModel Artist { get; set; } = new ArtistModel();

        public AddArtistViewModel(NavigationStore navigationStore, ArtistService artistService)
        {
            _navigationStore = navigationStore;
            _artistService = artistService;

            AddCommand = AddArtist();
            CancelCommand = Cancel();

           
        }

     
       
        private ICommand AddArtist()
        {


          

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
