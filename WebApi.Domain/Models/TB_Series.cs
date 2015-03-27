using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Series
    {
        public int ID_Serio { get; set; }
        public Nullable<int> ID_EXERCICIO { get; set; }
        public Nullable<System.DateTime> DT_Data { get; set; }
        public Nullable<int> NR_Repeticoes { get; set; }
        public string NR_Peso { get; set; }
    }
}
