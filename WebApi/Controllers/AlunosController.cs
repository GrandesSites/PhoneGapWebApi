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
    public class AlunosController : ApiController
    {
        public IEnumerable<TB_Login> Get(int id, int? Aprovado)
        {
            var saida = new TB_RelacionamentoRepository();
            return saida.ListaAlunos(id, Aprovado);
        }

    }
}
