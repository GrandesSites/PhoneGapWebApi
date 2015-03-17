using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Exercicios
    {
        public int ID_EXERCICIO { get; set; }
        public string DS_EXERCICIO { get; set; }
        public string ID_YOUTUBE { get; set; }
        public int ST_STATUS { get; set; }
    }
}
