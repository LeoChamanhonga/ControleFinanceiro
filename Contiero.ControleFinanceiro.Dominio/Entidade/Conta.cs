using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiero.ControleFinanceiro.Dominio.Entidade
{
    class Conta
    {
        public int Conta_ID { get; set; }
        public string Nome { get; set; }
        public int Agencia { get; set; }
        public string Conta { get; set; }
    }
}
