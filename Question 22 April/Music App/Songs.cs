using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class Songs : BaseModel
    {
        public string Name { get; set; }
        public DateTime Announcement { get; set; }
        public DateTime ReleaseDate { get => Announcement.AddDays(10); }
        public double Time { get; set; }
        public Artist artist { get; set; }
    }
}
