using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Models
{
    // Classe que guarda as informações de imagem de um video
    public class ImageDAO
    {        
        public int Height { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }
}
