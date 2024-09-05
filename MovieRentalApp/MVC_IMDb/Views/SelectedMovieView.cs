using MVC_IMDb.Forms;
using MVC_IMDb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MVC_IMDb.Views
{
    public class SelectedMovieView
    {
        private FormSelectedMovie form;
        // Referência readonly ao model, porque a view não pode alterar o model
        private readonly UserModel model;
        private readonly MovieDAO selectedMovie;


        // Tipo de event handler para poder passar ao controller o utilizador e email
        public delegate void RequisicaoEventHandler(object origem, string utilizador, string email);
        // É feito o assign deste dentro do controller
        public event RequisicaoEventHandler EventoDeRequisicao;


        // Tipo de event handler para poder passar ao controller o utilizador e email
        public delegate void ComentarioEventHandler(object origem, string texto);
        // É feito o assign deste dentro do controller
        public event ComentarioEventHandler EventoDeComentar;

        public SelectedMovieView(UserModel _model, MovieDAO _movie)
        {
            model = _model;
            selectedMovie = _movie;

            // Cria um novo form de seleção de filmes
            form = new FormSelectedMovie(this);

            form.PreencherDadosDoFilme(selectedMovie);
        }


        // Mostra o form de login
        public void FormDeSelecaoDeFilme()
        {
            form.ShowDialog();
        }
        public void CliqueEmRequisitarFilme(object origem, string utilizador, string email)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeRequisicao != null)
                EventoDeRequisicao(origem, utilizador, email);
        }
        public void CliqueEmGravarComentario(object origem, string texto)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeComentar != null)
                EventoDeComentar(origem, texto);
        }

        public UserModel GetUserModel()
        {
            return model;
        }
        public void AtualizarComentarios(BindingList<string> comentarios) {
            form.AtualizaListaDeComentarios(comentarios);
        }
    }
}
