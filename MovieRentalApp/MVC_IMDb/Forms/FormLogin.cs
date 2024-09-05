using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MVC_IMDb.Views;
using MVC_IMDb.Controllers;
using System.IO;
using MVC_IMDb.Models;
using Newtonsoft.Json;

namespace MVC_IMDb.Forms
{
    public partial class FormLogin : Form
    {
        // View associada ao form de login
        private LoginView view;
        public FormLogin(LoginView _view)
        {
            InitializeComponent();

            // Fixa o form no centro do ecrã
            StartPosition = FormStartPosition.CenterScreen;

            // Guarda uma referência à view de login para lhe poder informar quando o utilizador carrega no botão de login
            view = _view;
        }

        // Ocorre quando o utilizador carrega no botão de login do form
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Testa se as credenciais foram preenchidas
            if (string.IsNullOrEmpty(_utilizadorTextBox.Text) || string.IsNullOrEmpty(_passwordTextBox.Text))
            {
                MessageBox.Show("Por favor preencha as credenciais.");
                return;
            }

            // Informa a view que o utilizador carregou no botão de login, para a view poder informar o controller
            view.CliqueEmFazerLogin(sender, _utilizadorTextBox.Text, _passwordTextBox.Text);
        }
        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void CreateAccountButton_CLick(object sender, EventArgs e)
        {

        }*/

        //para o json { id, nome, email, hashed password }
        private void CriarContaButton_Click(object sender, EventArgs e)
        {
            view.CliqueEmCriarConta(sender);
            //CreateAccountController controller = new CreateAccountController(view.);

            //controller.IniciarJanela();
            //FormCreateAccount Form = new FormCreateAccount(controller.GetView());
            //Form.ShowDialog();
            //Form.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            view.PreecherDadosUtilizadores(sender);
        }
    }
}