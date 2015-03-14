using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Domain.Models;
using WebApiRepository.Interfaces;

namespace WebApiRepository
{
    public class TB_LoginRepository:RepositoryBase<TB_Login>, ITB_Login
    {
        public TB_Login Login(string DS_Login, string DS_Senha)
        {
            var DB = new DB_9BB59F_siteContext();
            TB_Login encontrado = DB.TB_Login.FirstOrDefault(X => X.DS_Login == DS_Login && X.DS_Senha == DS_Senha);
            TB_Login saida = new TB_Login();
            if (encontrado != null)
            {
                saida = encontrado;
            }
            return saida;
        }

        public bool Cadastra(TB_Login Itens)
        {
            var DB = new DB_9BB59F_siteContext();
            var encontrado = DB.TB_Login.FirstOrDefault(X => X.DS_Login == Itens.DS_Login);
            var _Banco = new TB_LoginRepository();
            if (encontrado == null)
            {
                _Banco.Add(Itens);
                return true;
            }
            else
            {
                return false;
            }

            
        }


    }
}