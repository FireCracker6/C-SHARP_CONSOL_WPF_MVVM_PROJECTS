using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Artist_APP_MVVM.Helpers;
using Artist_APP_MVVM.Services;

namespace Artist_APP_MVVM.MVVM.ViewModels
{
    internal class ArtistsViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly ArtistService _artistService;

        public ICommand NavigateToAddCommand { get; }

        public ArtistsViewModel(NavigationStore navigationStore, ArtistService artistService)
        {
            _navigationStore = navigationStore;
            _artistService = artistService;
           // _navigationStore.CurrentViewModel = new AddArtistViewModel(navigationStore);
          NavigateToAddCommand = new NavigateCommand<AddArtistViewModel>(navigationStore, () => new AddArtistViewModel(_navigationStore,_artistService));
        }

        

       
    }
}
