using MVC_IMDb.Controllers;
using MVC_IMDb.Models;
using MVC_IMDb.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MVC_IMDb.Forms
{
    public partial class FormMoviesList : Form
    {
        // View associada ao form de login
        private MoviesListView view;

        public FormMoviesList(MoviesListView _view)
        {
            InitializeComponent();

            // Fixa o form no centro do ecrã
            StartPosition = FormStartPosition.CenterScreen;

            view = _view;
        }
        private void FormMoviesList_Load(object sender, EventArgs e)
        {
            // Adiciona as colunas necessárias ao Datagridview
            AdicionarColunas();

            // Preenche a datagridview com os dados dos filmes obtidos no model
            view.ListarFilmes(sender);
        }
        // Prepara o datagridview com as colunas corretas para apresentar os filmes
        private void AdicionarColunas()
        {
            // Coluna com o poster do filme
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Imagem";
            imageColumn.Name = "Image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.Columns.Add(imageColumn);

            // Coluna com os descritivos em texto do filme
            dataGridView.Columns.Add("Title", "Titulo");
            dataGridView.Columns.Add("RunningTimeInMinutes", "Duração");
            dataGridView.Columns.Add("Year", "Ano");
        }
        public void PreencherListaDeFilmes(List<MovieDAO> filmes)
        {
            foreach (var obj in filmes)
            {
                // Adiciona uma linha à dataGridView e guarda o seu índice
                var row = dataGridView.Rows[dataGridView.Rows.Add()];

                row.Cells["Image"].Value = obj.Image;
                row.Cells["Title"].Value = obj.Title;
                row.Cells["RunningTimeInMinutes"].Value = obj.RunningTimeInMinutes + " minutos";
                row.Cells["Year"].Value = obj.Year;

                // Add the image to the "Image" cell
                Image image = MovieModel.CreateImage(obj.Image); // Get the image from the object
                row.Cells["Image"].Value = image;
            }
        }
        private void EscolherFilmeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                view.CliqueEmSelecionarFilme(sender, dataGridView.SelectedCells[0].RowIndex);
            }
            else
            {
                MessageBox.Show("Escolha um filme primeiro.");
            }
        }

        private void RecolherFilmeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;

                ReservationsController selectedMovieController = new ReservationsController(new UserModel());
                selectedMovieController.IniciarFormDeReservaDeFilme();

            }
            else
            {
                MessageBox.Show("Escolha um filme primeiro.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
