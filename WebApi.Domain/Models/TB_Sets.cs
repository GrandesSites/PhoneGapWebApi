using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Sets
    {
        public TB_Sets()
        {
            this.TB_Series = new List<TB_Series>();
        }

        public int ID_Set { get; set; }
        public string DS_Set { get; set; }
        public Nullable<int> ST_ATIVO { get; set; }
        public virtual ICollection<TB_Series> TB_Series { get; set; }
    }
}
