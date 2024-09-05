using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MVC_IMDb.Models
{
    public class CommentModel : IComment
    {
        private List<CommentDAO> comments;

        private UserModel user;
        private string movieID;
        public CommentModel(string _movieId,UserModel _user)
        {
            movieID = _movieId;

            user = _user;
            

            ///ler de json

            string jsonFile = System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\BaseDeDados\comentarios.json";
            string json = File.ReadAllText(jsonFile);
            List<CommentDAO>tempcomments = JsonConvert.DeserializeObject<List<CommentDAO>>(json);

            comments = new List<CommentDAO>();
            if (tempcomments != null)
            {
                
                foreach (CommentDAO comment in tempcomments)
                {
                    if (comment.MovieId == movieID)
                        comments.Add(comment);
                }
            }
            


        }

        public BindingList<string> DevolverComentarios()
        {
            BindingList<string> data = new BindingList<string>();
            for (int i = 0; i < comments.Count; i++)
            {
                data.Add(comments[i].CommentDatetime + " - " + user.GetUsers().Where(u => u.userID == comments[i].UserId).First().username + ":");
                data.Add("\t" + comments[i].CommentText);
            }

            return data;
        }
        public List<CommentDAO> GetComments()
        {

            return comments;
            
            
        }

        public void SetComment( int UserId, string comment)
        {
            CommentDAO newComment = new CommentDAO
            {
                CommentId = comments.Count + 1,
                MovieId = movieID,
                UserId = UserId,
                CommentDatetime = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                CommentText = comment
            };

            comments.Add(newComment);
            GuardarComentarios();
        }


        public void GuardarComentarios()
        {
            var JsonData = JsonConvert.SerializeObject(comments, Formatting.Indented);

            string jsonFile = System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\BaseDeDados\comentarios.json";

            File.WriteAllText(jsonFile, JsonData);
        }
    }
}
