using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_IMDb.Models;
using MVC_IMDb.Views;

namespace MVC_IMDb.Controllers
{
    public class CreateAccountController
    {
        private UserModel model;
        private CreateAccountView view;

        //private User[] users = LoginController.GetUsers();
        public CreateAccountController(UserModel _model)
        {
            model = _model;
            view = new CreateAccountView(model);

            view.EventoDeCriarConta += CriarConta;

            model.EstadoDeCriacaoAlterado += view.SolicitarEstadoCriacao;

        }
        public void IniciarJanela()
        {
            view.FormCriarConta();
        }

        public void CriarConta(object sender, string utilizador, string email, string password)
        {

            if (model.VerificarDadosCriarConta(utilizador, email))
            {
                model.CriarConta(utilizador, email, password);
                //view.SolicitarEstadoCriacao;
            }
        }
    }
}
