using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP_CONTACTS_MVVM.MVVM.Models
{
    public partial class ArtistSongsRecorded
    {
       public Guid GuidSongNameId { get; set; }   = Guid.NewGuid();
       public string SongName { get; set; } = string.Empty;
       public ContactModel ArtistName { get; set; } = null!;

    }
}
