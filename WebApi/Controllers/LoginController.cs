using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
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

        public bool Get(string DS_Login, string DS_Senha)
        {
            var _Banco = new TB_LoginRepository();
            return _Banco.Login(DS_Login, DS_Senha);

        }

        public void Post([FromBody]string DS_Login)
        {
        }
        
    }
}
