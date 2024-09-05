using MVC_IMDb.Forms;
using MVC_IMDb.Models;
using System.Collections.Generic;

namespace MVC_IMDb.Views
{
    public class MoviesListView
    {
        private FormMoviesList form;
        private readonly MovieModel model;

        public delegate void FilmesEventHandler(object origem);
        public event FilmesEventHandler? EventoDeListarFilmes;

        public delegate void SelecionarFilmeEventHandler(object origem, int index);
        public event SelecionarFilmeEventHandler? EventoDeSelecionarFilme;


        public MoviesListView(MovieModel _model)
        {
            // Cria um novo form de menu
            form = new FormMoviesList(this);
            model = _model;
        }

        public void FormDeListaDeFilmes()
        {
            form.ShowDialog();
        }
        public void ListarFilmes(object origem)
        {
            if (EventoDeListarFilmes != null)
                EventoDeListarFilmes(origem);
        }
        public void CliqueEmSelecionarFilme(object origem, int index)
        {
            if (EventoDeSelecionarFilme != null)
                EventoDeSelecionarFilme(origem, index);
        }
        public void PreencherListaDeFilmes(List<MovieDAO> filmes)
        {
            form.PreencherListaDeFilmes(filmes);
        }
    }
}
