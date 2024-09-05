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
using System.Security.Policy;
using static System.Console;
using System.IO;

namespace MVC_IMDb
{
    public partial class FormCreateAccount : Form
    {
        private CreateAccountView view;
        public FormCreateAccount(CreateAccountView _view)
        {
            InitializeComponent();

            // Fixa o form no centro do ecrã
            StartPosition = FormStartPosition.CenterScreen;

            // Guarda uma referência à view de login para lhe poder informar quando o utilizador carrega no botão de login
            view = _view;
        }


        //para o json { id, nome, email, hashed password }
        private void CriarContaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_utilizadorTextBox.Text) || string.IsNullOrEmpty(_passwordTextBox.Text) || string.IsNullOrEmpty(_emailTextBox.Text))
            {
                MessageBox.Show("Por favor preencha os campos todos.");
                return;
            }

            view.CliqueEmCriarConta(sender, _utilizadorTextBox.Text, _emailTextBox.Text, _passwordTextBox.Text);



        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
