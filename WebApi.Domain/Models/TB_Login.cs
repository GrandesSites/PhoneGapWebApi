using System;
using System.Collections.Generic;

namespace WebApi.Domain.Models
{
    public partial class TB_Login
    {
        public int ID_login { get; set; }
        public string DS_Login { get; set; }
        public string DS_Senha { get; set; }
        public string DS_Nome { get; set; }
        public Nullable<int> Bit_Aluno { get; set; }
        public Nullable<int> Bit_Professor { get; set; }
    }
}
