using MVC_IMDb.Models;
using MVC_IMDb.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Controllers
{
    public class MenuController
    {
        private readonly UserModel model;
        private MenuView view;
        public MenuController(UserModel _model)
        {
            model = _model;
            view = new MenuView();

            view.EventoDeListarFilmes += ListarFilmes;
            view.EventoDeRequisitarFilmes += ListarRequisicoes;
        }
        public void IniciarPrograma()
        {
            view.FormDeMenu();

        }
        public void ListarFilmes(object origem)
        {
            MoviesListController moviesList = new MoviesListController(model);
            moviesList.IniciarFormDeListaDeFilmes();

        }
        public void ListarRequisicoes(object origem)
        {
            ReservationsController moviesReserved = new ReservationsController(model/*,lista de filmes*/);
            moviesReserved.IniciarFormDeReservaDeFilme();
        }
    }
}
