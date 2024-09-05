//using Facebook;
using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MVC_IMDb.Models
{
    public class UserModel
    {
        // Credenciais do utilizador
        private UserDAO utilizador;
        private List<UserDAO> utilizadores;

        // Serve para notificar a view que o estado de login foi alterado
        public event PropertyChangedEventHandler? EstadoDeLoginAlterado;

        // Serve para notificar a view que o estado de login foi alterado
        public event PropertyChangedEventHandler? EstadoDeCriacaoAlterado;

        // Estado de login, inicializa-se a falso
        private bool FezLogin;
        // Estado de Criar Conta, inicia-se a falso
        private bool CriouConta;
        // Serve para alterar o estado de login sob o padrão de design Observer
        private bool EstadoLogin
        {
            set
            {
                FezLogin = value;
                MudarEstadoDeAutenticacao("FezLogin"); // Informa a view do novo estado de login
            }
        }

        private bool EstadoCriouConta
        {
            set
            {
                CriouConta = value;
                MudarEstadoDeCriacao("CriouConta"); // Informa a view do novo estado de login
            }
        }

        public UserModel()
        {
            utilizador = new UserDAO();
            utilizador.username = string.Empty;
            utilizador.password = string.Empty;
            utilizador.email = string.Empty;
            utilizador.userID = 0;// Como o ID comeca em 1, iniciamos em 0;
            FezLogin = false;
            CriouConta = false;

            PreencherDadosUtilizadores();
        }
        public int GetUserId()
        {
            return utilizador.userID;
        }
        public string GetUserName()
        {
            return utilizador.username;
        }
        public string GetUserEmail()
        {
            return utilizador.email;
        }
        public void Autenticar(string _username, string _password)
        {
            bool login = false;

            foreach (UserDAO user in utilizadores)
            {
                if (_password.Equals(user.password) && _username.Equals(user.username))
                {
                    login = true;
                    utilizador = user;
                    break;
                }
            }

            EstadoLogin = login;


        }
        // Informa a view que o estado de login mudou
        protected void MudarEstadoDeAutenticacao(string propertyName)
        {
            EstadoDeLoginAlterado?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // Usado para a view poder obter o estado de login
        public bool GetEstadoLogin()
        {
            return FezLogin;
        }
        public bool GetEstadoCriacao()
        {
            return CriouConta;
        }

        public bool VerificarDadosCriarConta(string _username, string _email)
        {
            foreach (UserDAO user in utilizadores)
            {

                if (_username == user.username || _email == user.email)
                {
                    return false;
                }

            }
            return true;
        }

        public void CriarConta(string _username, string _email, string _password)
        {
            UserDAO newUser = new UserDAO();
            newUser.username = _username;
            newUser.email = _email;
            newUser.password = _password;
            newUser.userID = utilizadores.Last().userID + 1;

            //Array.Resize(ref utilizadores, utilizadores.Length + 1);
            utilizadores.Add(newUser);

            var JsonData = JsonConvert.SerializeObject(utilizadores, Formatting.Indented);

            string jsonFile = System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\BaseDeDados\utilizadores.json";

            File.WriteAllText(jsonFile, JsonData);
            //C:\Users\Pedro\Documents\GitHub\Grupo13LabDS\MVC_IMDb\BaseDeDados\utilizadores.json
            EstadoCriouConta = true; 
        }

        protected void MudarEstadoDeCriacao(string created)
        {

            EstadoDeCriacaoAlterado?.Invoke(this, new PropertyChangedEventArgs(created));
        }

        public void PreencherDadosUtilizadores()
        {
            string jsonFile = System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\BaseDeDados\utilizadores.json";
            string json = File.ReadAllText(jsonFile);

            utilizadores = JsonConvert.DeserializeObject<List<UserDAO>>(json);

        }

        public List<UserDAO> GetUsers()
        {
            return utilizadores;
        }

        
    }
}
