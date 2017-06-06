using DistribuaAlimento.Models;
using DistribuaAlimento.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList; 

namespace DistribuaAlimento.Controllers
{
    public class DistribuicaoController : Controller
    {
        IArrecadadoServico _IArrecadadoServico { get; set; }
        IEventoServico _IEventoServico { get; set; }
        IEstoqueServico _IEstoqueServico { get; set; }
        IAlimentoServico _IAlimentoServico { get; set; }
        // GET: Distribuicao
        public ActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            IQueryable<Arrecadado> arrecadado = null;
            //dividir igualmente




            arrecadado = Consulta();

            return View(arrecadado.ToPagedList(pageNumber, pageSize));

            
        }

        public IQueryable<Arrecadado> Consulta()
        {
            IEnumerable<Arrecadado> _arrecadadoIEnumerable = Enumerable.Empty<Arrecadado>();
            _arrecadadoIEnumerable = _IArrecadadoServico.ListarTudo();
            //_arrecadadoIEnumerable = from a in _IArrecadadoServico.ListarTudo()
            //                         join ev in _IEventoServico.ListarTudo() on a.id equals ev.idArrecadado
            //                         join es in _IEstoqueServico.ListarTudo() on ev.id equals es.id
            //                         join al in _IAlimentoServico.ListarTudo() on es.id equals al.idEstoque
            //                         select a;

            var query = _arrecadadoIEnumerable.AsQueryable();
            return query;
        }
        public ActionResult Doar(int id)
        {

            if (ModelState.IsValid)
            {
                //*** Exclui alvara


                var alimento = _IAlimentoServico.ObterPorID(id);
                return View(alimento);

            }
            else
            {
                return HttpNotFound();
            }
        }

    }
}