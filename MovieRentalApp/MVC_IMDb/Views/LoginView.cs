using MVC_IMDb.Models;
using MVC_IMDb.Forms;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVC_IMDb.Views
{
    public class LoginView
    {
        private FormLogin janela;
        // Referência readonly ao model, porque a view não pode alterar o model
        private readonly UserModel model;

        // Tipo de event handler para poder passar ao controller o utilizador e password
        public delegate void LoginEventHandler(object sender, string utilizador, string password);
        // É feito o assign deste dentro do controller
        public event LoginEventHandler? EventoDeAutenticacao;

        public delegate void CreateAccountEventHandler(object sender);
        // É feito o assign deste dentro do controller
        public event CreateAccountEventHandler? EventoDeCriarConta;

        // Tipo de event handler para poder passar ao controller o utilizador e password
        public delegate void DataReadEventHandler(object sender);
        // É feito o assign deste dentro do controller
        public event DataReadEventHandler? EventoDeLeitura;

        public LoginView(UserModel _model)
        {
            model = _model;
            // Cria um novo form de login
            janela = new FormLogin(this);
        }
        // Mostra o form de login
        public void FormDeLogin()
        {
            janela.ShowDialog();
        }
        // Acontece quando o utilizador carrega no botão de fazer login
        public void CliqueEmFazerLogin(object origem, string utilizador, string password)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeAutenticacao != null)
                EventoDeAutenticacao(origem, utilizador, password);
        }
        // Solicita ao model o estado de login
        public void SolicitarEstadoDeLogin(object? sender, PropertyChangedEventArgs e)
        {
            if (model.GetEstadoLogin())
            {
                janela.Close();
                MessageBox.Show("Login realizado com sucesso!");
            }
            else
                MessageBox.Show("Credenciais erradas, tente de novo.");
        }
        public void PreecherDadosUtilizadores(object origem)
        {
            if (EventoDeLeitura != null)
                EventoDeLeitura(origem);

        }

        public void CliqueEmCriarConta(object origem)
        {
            // Error handle a ser feito mais tarde, mas para já basta ver se o evento "existe"
            if (EventoDeCriarConta != null)
                EventoDeCriarConta(origem);
        }
    }
}
