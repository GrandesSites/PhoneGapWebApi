using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Series
    {
        public TB_Series()
        {
            this.TB_Exercicio = new List<TB_Exercicio>();
        }

        public int ID_Serie { get; set; }
        public Nullable<int> ID_Set { get; set; }
        public string DS_Serie { get; set; }
        public Nullable<int> ST_ATIVO { get; set; }
        public virtual ICollection<TB_Exercicio> TB_Exercicio { get; set; }
        public virtual TB_Sets TB_Sets { get; set; }
    }
}
