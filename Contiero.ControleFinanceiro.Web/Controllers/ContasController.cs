using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contiero.ControleFinanceiro.Dominio.Repositorio;

namespace Contiero.ControleFinanceiro.Web.Controllers
{
    public class ContasController : Controller
    {

        private ContasRepositorio _repositorio;
        // GET: Conta
        public ActionResult Index()
        {
            _repositorio = new ContasRepositorio();
            var contas = _repositorio.Contas.Take(2);
            return View(contas);
        }
    }
}