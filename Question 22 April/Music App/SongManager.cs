using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class SongManager : BaseModel, ISongEntity
    {
        public DateTime LastPlayDate { get ; set ; }
        public Songs song { get ; set ; }

        public SongManager(Songs song)
        {
            this.song = song;
        }

        public string CalculatePlayDate (DateTime dt)
        {
            return dt.ToString("dd MMMM yyyy, DDDDD");
        }

       


        public void PlaySong(ICall playable)
        {
            Console.WriteLine("Playing");
            playable.Cal((Songs)playable);
        }




    }

}
