using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Domain.Models;
using WebApiRepository.Interfaces;

namespace WebApiRepository
{
    public class TB_RelacionamentoRepository : RepositoryBase<TB_Relacionamento>, ITB_Relacionamento
    {
        public IEnumerable<TB_Login> ProcuraProfessor(string quem)
        {
            var DB = new DB_9BB59F_siteContext();
            var saida = DB.TB_Login.Where(X => X.DS_Nome.Contains(quem) && X.Bit_Professor == 1).ToList();
            return saida;
        }

        public bool ConvidaProfessor(int ID_REQUISITANTE, int ID_REQUISITADO)
        {
            try
            {
                var _Banco = new TB_RelacionamentoRepository();
                var Model = new TB_Relacionamento();
                Model.ID_REQUISITADO = ID_REQUISITADO;
                Model.ID_REQUISITANTE = ID_REQUISITANTE;
                _Banco.Add(Model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AlteraAluno(int ID_REQUISITANTE, int ID_REQUISITADO, int APROVADO, int REPROVADO)
        {
            try
            {
                var db = new DB_9BB59F_siteContext();
                var Model = new TB_Relacionamento();
                var _Banco = new TB_RelacionamentoRepository();
                Model =
                    db.TB_Relacionamento.FirstOrDefault(
                        X => X.ID_REQUISITANTE == ID_REQUISITANTE && X.ID_REQUISITADO == ID_REQUISITADO);
                Model.BIT_APROVADO = APROVADO;
                Model.BIT_REPROVADO = REPROVADO;
                if (REPROVADO == 0)
                {
                    //para a logica funcionar mais facil e melhor deletar o pedido de professor
                    _Banco.Remove(Model);
                }
                else
                {
                    _Banco.Update(Model);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
 
        public IEnumerable<TB_Login> ListaAlunos(int id)
        {
            var db = new DB_9BB59F_siteContext();
            var Relacionamento =
                db.TB_Relacionamento.FirstOrDefault(X => X.ID_REQUISITADO == id && X.BIT_APROVADO == null);
            var saida = db.TB_Login.Where(X => X.ID_login == Relacionamento.ID_REQUISITANTE).ToList();
            return saida;
        }

        public bool ListaProfessores(int id)
        {
            var db = new DB_9BB59F_siteContext();
            var saida = db.TB_Relacionamento.FirstOrDefault(X => X.ID_REQUISITANTE == id);
            var TBLog = new TB_Login();
            if (saida != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}