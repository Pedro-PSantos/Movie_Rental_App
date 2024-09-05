using MVC_IMDb.Models;
using MVC_IMDb.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace MVC_IMDb.Forms
{
    public partial class FormSelectedMovie : Form
    {
        private SelectedMovieView view;

        public FormSelectedMovie(SelectedMovieView _view)
        {
            InitializeComponent();

            // Fixa o form no centro do ecrã
            StartPosition = FormStartPosition.CenterScreen;

            // Guarda uma referência à view do filme selecionado
            view = _view;

        }

        public void PreencherDadosDoFilme(MovieDAO movie)
        {
            pictureBox3.Image = MovieModel.CreateImage(movie.Image);
            TituloLabel.Text += movie.Title;
            DuracaoLabel.Text += movie.RunningTimeInMinutes + " minutos";
            AnoLabel.Text += movie.Year;
        }

        private void RequisitarFilmeButton_Click(object sender, EventArgs e)
        {
            view.CliqueEmRequisitarFilme(sender, view.GetUserModel().GetUserName(), view.GetUserModel().GetUserEmail());
        }

        private void ComentarioButton_Click(object sender, EventArgs e)
        {
            view.CliqueEmGravarComentario(sender, ComentarioTextBox.Text);
            ComentarioTextBox.Text = "";
        }
        // Botao de encerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComentarioTextBox_Click(object sender, EventArgs e)
        {
            // Remover a ajuda quando o user for escrever
            if (ComentarioTextBox.Text.Equals("Adicione um comentário..."))
                ComentarioTextBox.Text = "";
        }

        private void ComentarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Para o enter não ir para a text box
                e.Handled = true;

                // Carrega no botão de gravar
                ComentarioButton_Click(sender, e);
            }
        }

        public List<string> GetListaDeComentarios()
        {
            List<string> listaDeComentarios = new List<string>();
            foreach (var comentario in ComentariosListBox.Items)
            {
                if (comentario != null)
                    listaDeComentarios.Add(comentario.ToString());
            }


            return listaDeComentarios;
        }
        public void AtualizaListaDeComentarios(BindingList<string> data)
        {
            ComentariosListBox.DataSource = data;
            ComentariosListBox.Refresh();
        }
    }
}
