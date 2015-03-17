using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Domain.Models;
using WebApiRepository;

namespace WebApi.Controllers
{
    public class ProfessoresController : ApiController
    {
        // GET api/professores
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/professores/5
        public bool Get(int id) //id do aluno que esta checando se ja procurou professor
        {
            var _Banco = new TB_RelacionamentoRepository();
            return _Banco.ListaProfessores(id);
        }

        // POST api/professores
        public void Post([FromBody]string value)
        {
        }

        // PUT api/professores/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/professores/5
        public void Delete(int id)
        {
        }
    }
}
