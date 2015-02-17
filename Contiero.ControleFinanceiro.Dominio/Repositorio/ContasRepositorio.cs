using Contiero.ControleFinanceiro.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiero.ControleFinanceiro.Dominio.Repositorio
{
    public class ContasRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Conta> Contas
        {
            get { return _context.Contas; }
        }
     
    }
}
