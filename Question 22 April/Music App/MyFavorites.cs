using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class MyFavorites : BaseModel
    {
        public List<Songs> Songs { get; set; }
        public User User { get; set; }
    }
}
