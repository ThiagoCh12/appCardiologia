using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCardiologia.Model
{
    internal class Exame
    {
        public int id { get; set; }
        public int registro_paciente { get; set; }
        public string tipo { get; set; }
        public DateTime data_prevista { get; set; }
    }
}
