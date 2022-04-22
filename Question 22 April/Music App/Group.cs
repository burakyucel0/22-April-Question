using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class Group : BaseModel
    {
        public string GroupName { get; set; }
        public DateTime Establish { get; set; } 
        public List<Artist> Artist { get; set; }

        public Group (string name) { this.GroupName = name; }
    }
}
