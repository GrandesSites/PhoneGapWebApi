﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Domain.Models;
using WebApiRepository.Interfaces;

namespace WebApiRepository
{
    public class TB_ConversasRepository: RepositoryBase<TB_CONVERSAS>, ITB_Conversas
    {

        public bool AvisaNaoLidas(int id)
        {
            var saida = Db.TB_CONVERSAS.Where(X => X.ST_LIDO == 0);
            return saida.Any();
        }
        
        public List<TB_CONVERSAS> ListaConvesas(int id)
        {
            return  Db.TB_CONVERSAS.Where(X => X.ID_TO == id).OrderByDescending(X => X.DT_DATA).Take(50).ToList();
        }
        
    }
}