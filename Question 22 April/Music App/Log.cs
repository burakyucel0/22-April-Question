using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public class Log : BaseModel
    {
        public string LogName { get; set; }
        public string LogDescription { get; set; }
        public int Category { get  ; set ; }
    }
}
