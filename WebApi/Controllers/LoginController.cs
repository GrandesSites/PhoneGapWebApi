using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using WebApi.Domain.Models;
using WebApiRepository;

namespace WebApi.Controllers
{
    public class LoginController : ApiController
    {


        public TB_Login Get()
        {
            var _Banco = new TB_LoginRepository();
            var saida = _Banco.GetAll().FirstOrDefault();
            //return Json.Encode(saida);
            return saida;
        }


        [System.Web.Http.HttpPost]
        public string Post(JObject model)
        {
            dynamic json = model;
            string DS_Login = json.DS_Login;
            string DS_Senha = json.DS_Senha;
            string DS_Nome = json.DS_Nome;
            var _Banco = new TB_LoginRepository();
            var retorno = _Banco.Login(DS_Login, DS_Senha);
            //nao consegui recuperar o objeto numa funcao que vem json e volta xml, entao vou tranformar numa string e la eu dou um split

            var msg = "";
            if (retorno.Bit_Aluno == null)
            {
                msg = "Login ou senha incorretos";
            }
            else
            {
                msg = "Bem vindo(a) " + retorno.DS_Nome;
            }
            return retorno.ID_login.ToString() + "," + retorno.Bit_Aluno.ToString() +"," + msg;
        }


    }
}
