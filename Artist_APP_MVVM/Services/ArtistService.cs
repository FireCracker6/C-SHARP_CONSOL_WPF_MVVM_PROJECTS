using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artist_APP_MVVM.MVVM.Models;
using Newtonsoft.Json;

namespace Artist_APP_MVVM.Services
{
    public  class ArtistService
    {
        private static ObservableCollection<ArtistModel> artists;


        private static FileService fileService = new FileService($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\artistsNew.json");


        static ArtistService()
        {
            try
            {
                artists = JsonConvert.DeserializeObject<ObservableCollection<ArtistModel>>(fileService.Read())!;

            }
            catch { artists = new ObservableCollection<ArtistModel>(); }
        }



        public static void AddToList(ArtistModel model)
        {
          
            Debug.WriteLine(model.ArtistName);
            fileService.Save(JsonConvert.SerializeObject(artists));
            artists.Add(model);
        }
        public static void UpdateArtist(ArtistModel model)
        {



            Debug.WriteLine(model.ArtistName);
            fileService.Save(JsonConvert.SerializeObject(artists));

        }



        public static void RemoveFromList(ArtistModel model)
        {
            artists.Remove(model);
            fileService.Save(JsonConvert.SerializeObject(artists));
        }


        public static ObservableCollection<ArtistModel> Artists()
        {
            return artists;
        }
    }
}
