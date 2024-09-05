using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Models
{
    public class CommentDAO
    {        
        public int CommentId { get; set; }
        public string MovieId { get; set; }
        public int UserId { get; set; }
        public string CommentDatetime { get; set; }
        public string CommentText { get; set; }
    }
}
