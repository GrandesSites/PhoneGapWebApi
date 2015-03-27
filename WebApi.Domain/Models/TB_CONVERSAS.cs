using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_CONVERSAS
    {
        public int ID_CONVERSA { get; set; }
        public Nullable<int> ID_FROM { get; set; }
        public Nullable<int> ID_TO { get; set; }
        public string DS_RECADO { get; set; }
        public Nullable<System.DateTime> DT_DATA { get; set; }
        public Nullable<int> ST_LIDO { get; set; }
    }
}
