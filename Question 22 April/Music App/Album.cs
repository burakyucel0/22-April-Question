using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class Album : BaseModel
    {
        public string AlbumName { get; set; }
        public List<Songs> Songs { get; set; }
        public int SongsCount { get => Songs.Count(); }
        public string AlbumCover { get; set; }
        public Artist artist { get; set; }
    }
}
