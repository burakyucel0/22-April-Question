using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_22_April.Music_App
{
    public abstract class BaseModel
    {
        public string Id { get; set; } = "";
        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}
