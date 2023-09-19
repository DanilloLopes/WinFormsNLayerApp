using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Comum
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set;}
        public string Nacionalidade { get; set; }

    }
}
