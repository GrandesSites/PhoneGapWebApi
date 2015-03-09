using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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


        public string Get()
        {
            var _Banco = new TB_LoginRepository();
            var saida = _Banco.GetAll().ToList();
            return Json.Encode(saida);
        }



    }
}
