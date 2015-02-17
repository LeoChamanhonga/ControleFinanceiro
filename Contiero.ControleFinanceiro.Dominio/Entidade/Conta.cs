using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiero.ControleFinanceiro.Dominio.Entidade
{
    public class Conta
    {
        [Key]
        public int Conta_ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Agencia { get; set; }

        [Required]
        public string NumConta { get; set; }

    }
}
