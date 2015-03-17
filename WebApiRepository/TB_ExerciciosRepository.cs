using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Domain.Models;
using WebApiRepository.Interfaces;

namespace WebApiRepository
{
    public class TB_ExerciciosRepository: RepositoryBase<TB_Exercicios>, ITB_Exercicios
    {
        public void Inativar(int id)
        {
            var _Banco = new TB_ExerciciosRepository();
            var dados = _Banco.GetById(id);
            dados.ST_STATUS = dados.ST_STATUS == 1 ? 0 : 1;
            _Banco.Update(dados);
        }
    }
}