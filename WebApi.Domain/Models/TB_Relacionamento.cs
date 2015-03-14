using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Relacionamento
    {
        public int ID_REL { get; set; }
        public int? ID_REQUISITANTE { get; set; }
        public int? ID_REQUISITADO { get; set; }
        public int? BIT_APROVADO { get; set; }
        public int? BIT_REPROVADO { get; set; }
    }
}
