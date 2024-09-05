using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVC_IMDb.Forms;
using MVC_IMDb.Models;

namespace MVC_IMDb.Views
{
    public class CreateAccountView
    {
        private FormCreateAccount janela;

        private readonly UserModel model;

        // Tipo de event handler para poder passar ao controller o utilizador e password
        public delegate void CreateAccountEventHandler(object sender, string utilizador, string email, string password);
        // É feito o assign deste dentro do controller
        public event CreateAccountEventHandler? EventoDeCriarConta;



        public CreateAccountView(UserModel _model)
        {
            model = _model;
            // Cria um novo form de login
            janela = new FormCreateAccount(this);
        }

        public void CliqueEmCriarConta(object origem, string utilizador,string email, string password)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeCriarConta != null)
                EventoDeCriarConta(origem, utilizador,email, password);
        }


        public void SolicitarEstadoCriacao(object? sender, PropertyChangedEventArgs e)
        {

            if (model.GetEstadoCriacao())
            {
                janela.Close();
                MessageBox.Show("Conta criada com sucesso!");
            }
        }


        public void FormCriarConta()
        {
            janela.ShowDialog();
        }
    }
}
