using MVC_IMDb.Models;
using MVC_IMDb.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Controllers
{
    public class SelectedMovieController
    {
        private SelectedMovieView view;
        private CommentModel commentModel;
        private readonly UserModel userModel;
        private readonly MovieDAO selectedMovie;

        public SelectedMovieController(UserModel _userModel, MovieDAO _selectedMovie)
        {
            userModel = _userModel;
            selectedMovie = _selectedMovie;

            commentModel = new CommentModel(_selectedMovie.Id, userModel);
            view =  new SelectedMovieView(_userModel, _selectedMovie);
            view.EventoDeComentar += Comentar;
            view.EventoDeRequisicao += Requisitar;
            BuscarComentarios();
            
        }
        public void IniciarFormDeSelecaoDeFilme()
        {
            view.FormDeSelecaoDeFilme();
        }
        public void Requisitar(object sender, string utilizador, string email)
        {

        }
        public void Comentar(object sender, string texto)
        {
            commentModel.SetComment(userModel.GetUserId(), texto);

            BuscarComentarios();
        }

        public void BuscarComentarios()
        {
            view.AtualizarComentarios(commentModel.DevolverComentarios());
        }
    }
}
