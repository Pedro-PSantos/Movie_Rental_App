using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel;

namespace MVC_IMDb.Models
{
    //Interface para comentário de filme
public interface IComment
{
	void SetComment(/*string MovieId,*/ int UserId, string comment);
    List<CommentDAO> GetComments(/*string MovieId*/);

    //string[] GetCommentsByUserId(int MovieId, int UserId);
}

  //Interface para filmes
  public interface IMovie
  {
    MovieDAO GetMovieById(string MovieId);
    void CarregarFilmes();
  }

  //Interface para request
  /*public interface IRequest
  {
        //List<Tuple<string,string>> GetRequestById(int RequestId);
        BindingList<string> GetRequests(int UserId);
  }**/
}
