using MVC_IMDb.Models;
using MVC_IMDb.Views;

namespace MVC_IMDb.Controllers
{
    public class MoviesListController
    {
        private MoviesListView view;
        private MovieModel model; //model.GetFilmes();
        private readonly UserModel userModel;
        public MoviesListController(UserModel _userModel)
        {
            model = new MovieModel();
            view = new MoviesListView(model);
            userModel = _userModel;

            view.EventoDeListarFilmes += ListarFilmes;
            view.EventoDeSelecionarFilme += SelecionarFilme;
        }
        public void IniciarFormDeListaDeFilmes()
        {
            view.FormDeListaDeFilmes();
        }
        public void ListarFilmes(object origem)
        {
            model.CarregarFilmes();

            view.PreencherListaDeFilmes(model.GetFilmes());
        }
        public void SelecionarFilme(object origem, int index)
        {
            MovieDAO? filme = model.GetMovieByIndex(index);

            if(filme != null)
            {
                SelectedMovieController selectedMovieController = new SelectedMovieController(userModel, filme);
                selectedMovieController.IniciarFormDeSelecaoDeFilme();
            }
            else
            {
                // TODO throw exception falha a selecionar filme
            }
        }
    }
}
