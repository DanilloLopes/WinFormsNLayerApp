using Negocio.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBase
    {
        [Required(ErrorMessage = "Não é obrigatório")]
        [StringLength(50)]
        [MinLength(5,ErrorMessage = "Nome muito curto")]
        public string Nome { get; set; }
        public bool Status { get; set; }

        public Cargo(string nome, bool status) 
        {
            Nome = nome;
            Status = status;

            CriadoPor = "Danillo";
            CriadoEm = DateTime.Now;

            AlteradoPor = "Danillo";
            AlteradoEm = DateTime.Now;
        }
    }
}
