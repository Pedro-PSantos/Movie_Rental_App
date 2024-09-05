using MVC_IMDb.Models;
using MVC_IMDb.Views;

namespace MVC_IMDb.Controllers
{
    public class LoginController
    {
        private UserModel model;
        private LoginView view;

        public LoginController()
        {
            model = new UserModel();
            view = new LoginView(model);

            // Ligar o evento de autenticação ao método do controller
            view.EventoDeAutenticacao += SolicitarAutenticacao;
            // Ligar o evento de estado de login ao método da view
            model.EstadoDeLoginAlterado += view.SolicitarEstadoDeLogin;

            view.EventoDeCriarConta += CriarConta;
        }
        // Inicializa o programa
        public void IniciarFormDeLogin()
        {
            view.FormDeLogin();
        }
        // Solicita ao model para tentar autenticar o utilizador com as credenciais inseridas
        public void SolicitarAutenticacao(object sender, string utilizador, string password)
        {
            model.Autenticar(utilizador, password);
        }

        public UserModel GetUserModel()
        {
            return model;
        }

        public void CriarConta(object origem)
        {
            CreateAccountController controllerCriarConta = new CreateAccountController(model);
            controllerCriarConta.IniciarJanela();
        }
    }
}