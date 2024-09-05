using MVC_IMDb.Forms;
using MVC_IMDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Views
{
    public class MenuView
    {
        private FormMenu janela;

        // Tipo de event handler para poder passar ao controller o utilizador e password
        public delegate void FilmesEventHandler(object sender);
        // É feito o assign deste dentro do controller
        public event FilmesEventHandler? EventoDeListarFilmes;

        // É feito o assign deste dentro do controller
        public event FilmesEventHandler? EventoDeRequisitarFilmes;

        public MenuView()
        {
            // Cria um novo form de menu
            janela = new FormMenu(this);
        }

        // Mostra o form de menu
        public void FormDeMenu()
        {
            janela.ShowDialog();
        }

        // Acontece quando o utilizador carrega no botão de filmes
        public void CliqueEmFilmes(object origem)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeListarFilmes != null)
                EventoDeListarFilmes(origem);
        }
        // Acontece quando o utilizador carrega no botão de requisições
        public void CliqueEmRequisicoes(object origem)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeRequisitarFilmes != null)
                EventoDeRequisitarFilmes(origem);
        }

    }
}
