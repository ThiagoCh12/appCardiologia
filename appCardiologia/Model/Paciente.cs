using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCardiologia.Model
{
    internal class Paciente
    {
        public int id { get; set; }
        public int registro { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string cor { get; set; }
        public int idade { get; set; }

    }
}
