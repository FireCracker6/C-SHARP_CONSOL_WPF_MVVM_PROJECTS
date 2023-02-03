using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.MV
{
    public class ContactModel
    {
        public int ArtistID { get; set; } = new int();
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
