using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class PlayList : BaseModel, ISongEntity
    {
        public List<Songs> PlayListSongs { get; set; }
        public User User { get; set; }
        public int PlayListCount { get => PlayListSongs.Count(); }
        public DateTime LastPlayDate { get; set; }
    }
}
