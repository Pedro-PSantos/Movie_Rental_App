using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Linq;

namespace MVC_IMDb.Forms
{
    public partial class FormReservations : Form
    {
        private ReservationsView view;
        public FormReservations(ReservationsView _view)
        {
            InitializeComponent();
            // Fixa o form no centro do ecrã
            StartPosition = FormStartPosition.CenterScreen;

            view = _view;
        }

        private void PreencherListaDeRequisicoes()
        {
            dataGridView.Columns.Add("Date", "Data de Requisição");
            dataGridView.Columns.Add("Title", "Titulo de Requisição");

            //TODO ir buscar à database
            //foreach (var obj in requisicoes)
            //{
            //    // Adiciona uma linha à dataGridView e guarda o seu índice
            //    var row = dataGridView.Rows[dataGridView.Rows.Add()];

            //    row.Cells["Image"].Value = obj.Image;
            //    row.Cells["Title"].Value = obj.Title;
            //    row.Cells["RunningTimeInMinutes"].Value = obj.RunningTimeInMinutes + " minutos";
            //    row.Cells["Year"].Value = obj.Year;

            //    // Add the image to the "Image" cell
            //    Image image = CreateImage(obj.Image); // Get the image from the object
            //    row.Cells["Image"].Value = image;
            //}
        }


        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VoltarButton_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarColunas()
        {
 
            // Coluna com os descritivos em texto do filme
            dataGridView.Columns.Add("Title", "Titulo");
            dataGridView.Columns.Add("StartDate", "Data de Reserva");
            dataGridView.Columns.Add("EndDate", "Limite de Entrega");
        }
        public void PreencherListaDeFilmes(List<ReservationDAO> requests)
        {
            foreach (var obj in requests)
            {
                // Adiciona uma linha à dataGridView e guarda o seu índice
                var row = dataGridView.Rows[dataGridView.Rows.Add()];

                string movieName = new string;

                BindingList<string> data = new BindingList<string>();
                for (int i = 0; i < requests.Count; i++)
                {
                    data.Add(comments[i].CommentDatetime + " - " + user.GetUsers().Where(u => u.userID == comments[i].UserId).First().username + ":");
                    data.Add("\t" + comments[i].CommentText);
                }

                row.Cells["Title"].Value = obj.;
                row.Cells["StartDate"].Value = obj.reservationDate;
                row.Cells["EndDate"].Value = obj.Year;

                // Add the image to the "Image" cell
                Image image = MovieModel.CreateImage(obj.Image); // Get the image from the object
                row.Cells["Image"].Value = image;
            }
        }
    }
}
