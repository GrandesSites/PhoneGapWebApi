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
        public bool Post(JObject model)
        {
            dynamic json = model;
            string DS_Login = json.DS_Login;
            string DS_Senha = json.DS_Senha;
            var _Banco = new TB_LoginRepository();
            return _Banco.Login(DS_Login, DS_Senha);
        }


    }
}
