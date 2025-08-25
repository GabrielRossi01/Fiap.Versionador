using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Versionador
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nome { get; set; }
        public int nrCEP { get; set; }
        public string dsEndereco { get; }
        public string CPF { get; set; }

    }
}
