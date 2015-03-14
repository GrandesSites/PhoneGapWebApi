using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using WebApi.Domain.Models;
using WebApiRepository;

namespace WebApi.Controllers
{
    public class CadastroController : ApiController
    {
        [System.Web.Http.HttpPost]
        public string Post(JObject model)
        {

            try
            {
                var _Banco = new TB_LoginRepository();
                var LoginModel = new TB_Login();
                dynamic json = model;
                LoginModel.DS_Login = json.DS_Login;
                LoginModel.DS_Senha = json.DS_Senha;
                LoginModel.DS_Nome = json.DS_Nome;
                LoginModel.Bit_Aluno = 0;
                LoginModel.Bit_Professor = 0;


                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                if (!rg.IsMatch(LoginModel.DS_Login))
                {
                    return "O campode nome de usuario deve ser seu email";
                }
                
                
                if (json.Escolha == "P")
                {
                    LoginModel.Bit_Professor = 1;
                }
                else
                {
                    LoginModel.Bit_Aluno = 1;
                }

                return _Banco.Cadastra(LoginModel) ? "Cadastro efetuado com sucesso" : "Este usuario ja se encontra cadastrado no banco de dados";
            }
            catch (Exception ex)
            {
                return "O cadastro não pode ser efetuado nesse momento, tente novamente mais tarde";
            }
        }
    }
}
