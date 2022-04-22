using System;
using Question_22_April.Music_App;

namespace Question_22_April
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayList playList = new PlayList(); ;
            

            Artist artist = new Artist("Arctic ", "Monkeys");
            var p1 = new Songs("Comolokko");
            p1.Time = 2.54;
            p1.Announcement =  new DateTime(1980, 02, 01);
            p1.artist = artist;
            p1.LastPlayDate = new DateTime(2022,04,11);

            var p2 = new Songs("Something Just Like This");

            var p3 = new Songs("Sea Shanty Medley");

            Log log = new Log();
            log.Category = ((int)enumLog.High);

            SongManager songmanager = new SongManager(p1);
            



            var Album = new Album();
            Album.AlbumName = "Sea Shanty Medley";
            Album.AlbumCover = "Cover";
         
          


            //Console.WriteLine(Album.SongsCount);

            Console.Read();
        }
    }
}
