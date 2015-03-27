using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Personalizacao
    {
        public int ID_SeriePersonalizada { get; set; }
        public Nullable<int> Id_NomePers { get; set; }
        public Nullable<int> ID_Professor { get; set; }
        public Nullable<int> ID_Exercicio { get; set; }
        public string NR_Repeticoes { get; set; }
        public string DS_Peso { get; set; }
    }
}
