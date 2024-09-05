using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Models
{
    // Objeto criado para aceder apenas aos seus dados (Data Access Object)
    public class MovieDAO
    {        
        public string Type { get; set; }
        public string Disambiguation { get; set; }
        public string Id { get; set; }
        public ImageDAO Image { get; set; }
        public int RunningTimeInMinutes { get; set; }
        public string Title { get; set; }
        public string TitleType { get; set; }
        public int Year { get; set; }

    }
}
