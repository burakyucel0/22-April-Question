using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class Songs : BaseModel, ICall, ISongEntity
    {
        public string SongName { get; set; } = "";
        public DateTime Announcement { get; set; } 
        public DateTime ReleaseDate { get => Announcement.AddDays(10); }
        public double Time { get; set; } =  0.0;
        public Artist artist { get; set; } 
        public DateTime LastPlayDate { get; set; } 

        public void Cal(Songs song)
        {
         
        }

        public Songs (string name)
        {
           this.SongName = name;
        }
    }
}
