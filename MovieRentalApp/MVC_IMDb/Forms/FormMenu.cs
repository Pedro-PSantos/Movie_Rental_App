using MVC_IMDb.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    public partial class FormMenu : Form
    {
        // View associada ao form de login
        private MenuView view;
        public FormMenu(MenuView _view)
        {
            InitializeComponent();

            // Fixa o form no centro do ecrã
            StartPosition = FormStartPosition.CenterScreen;

            // Guarda uma referência à view de menu para lhe poder informar quando o utilizador carrega num botão
            view = _view;
        }
        // Ocorre quando o utilizador carrega no botão de filmes do form
        private void FilmesButton_Click(object sender, EventArgs e)
        {
            // Informa a view que o utilizador carregou no botão de login, para a view poder informar o controller
            view.CliqueEmFilmes(sender);

        }
        // Ocorre quando o utilizador carrega no botão de requisitar filmes do form
        private void RequisicoesButton_Click(object sender, EventArgs e)
        {
            // Informa a view que o utilizador carregou no botão de login, para a view poder informar o controller
            view.CliqueEmRequisicoes(sender);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}