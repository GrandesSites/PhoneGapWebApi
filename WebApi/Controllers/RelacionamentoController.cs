using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using WebApi.Domain.Models;
using WebApiRepository;

namespace WebApi.Controllers
{
    public class RelacionamentoController : ApiController
    {
        // GET api/relacionamento
        public IEnumerable<TB_Login> Get(string nome)
        {
            var _Banco = new TB_RelacionamentoRepository();
            var retorno = _Banco.ProcuraProfessor(nome);
            return retorno;
        }



        [HttpPost]
        public string Post(JObject model)
        {
            dynamic json = model;
            int ID_REQUISITANTE = json.ID_REQUISITANTE; //id aluno
            int ID_REQUISITADO = json.ID_REQUISITADO;
            int APROVADO = json.APROVADO;
            int REPROVADO = json.REPROVADO;

            bool retorno = false;
            var msg = "";
            var _Banco = new TB_RelacionamentoRepository();

            if (APROVADO == 0 && REPROVADO == 0) //se for so um convite essas duas variaveis serao 0
            {
                retorno = _Banco.ConvidaProfessor(ID_REQUISITANTE, ID_REQUISITADO);
                msg = retorno ? "Convite enviado com sucesso" : "C convite nao pod ser enviado nesse momento, tente novamente mais tarde";
            }
            else
            {
                retorno = _Banco.AlteraAluno(ID_REQUISITANTE, ID_REQUISITADO, APROVADO, REPROVADO);
                msg = retorno ? "Status alterado com sucesso" : "O Status não pode ser alterado nesse momento, tente novamente mais tarde";
            }
            return msg;
        }
    }
}
