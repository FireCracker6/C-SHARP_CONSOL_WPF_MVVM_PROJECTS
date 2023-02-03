using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artist_APP_MVVM.MVVM.Models
{
    public class ArtistModel
    {
        public Guid ArtistId { get; set; } = Guid.NewGuid();
        public string ArtistName { get; set; } = string.Empty;
        public string Associates { get; set; } = string.Empty;
        public string RecordLabel { get; set; } = string.Empty;
        public string ArtistSongs { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
