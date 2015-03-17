using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Series
    {
        public int ID_Serie { get; set; }
        public Nullable<int> ID_Set { get; set; }
        public string DS_Serie { get; set; }
        public Nullable<int> ST_ATIVO { get; set; }
        public virtual TB_Sets TB_Sets { get; set; }
    }
}
