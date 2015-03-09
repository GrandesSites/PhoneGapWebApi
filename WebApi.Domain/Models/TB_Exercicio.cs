using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Exercicio
    {
        public int ID_Exercicio { get; set; }
        public Nullable<int> ID_Serie { get; set; }
        public string DS_Peso { get; set; }
        public Nullable<int> NR_Series { get; set; }
        public Nullable<int> NR_Repeticoes { get; set; }
        public Nullable<System.DateTime> DT_Data { get; set; }
        public Nullable<int> ST_ATIVO { get; set; }
        public virtual TB_Series TB_Series { get; set; }
    }
}
