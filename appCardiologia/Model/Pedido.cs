using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCardiologia.Model
{
    internal class Pedido
    {
        public int id { get; set; }
        public int registro_paciente { get; set; }
        public string tipo { get; set; }
        public string situacao { get; set; }

    }
}
