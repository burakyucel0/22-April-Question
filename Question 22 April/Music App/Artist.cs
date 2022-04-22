using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class Artist : BaseModel
    {
        public string ArtistName { get; set; } 
        public string ArtistSurname { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }

        public Artist (string name, string surname)
        {

        }
    }
}
