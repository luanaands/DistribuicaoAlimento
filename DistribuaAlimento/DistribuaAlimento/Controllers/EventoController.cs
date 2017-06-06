using System.Collections.Generic;
using DistribuaAlimento.Models;
using DistribuaAlimento.Servico.Interface;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System;

namespace DistribuaAlimento.Controllers
{
    public class EventoController : Controller
    {
        public IInstituicaoServico _IInstituicaoServico { get; set; }
        public IArrecadadoServico _IArrecadadoServico { get; set; }
        public IEventoServico _IEventoServico { get; set; }

        // GET: Instituicao
        public ActionResult Index()
        {

            IEnumerable<Evento> _alvaraIEnumerable = Enumerable.Empty<Evento>();
            _alvaraIEnumerable = _IEventoServico.ListarTudo();
            return View(_alvaraIEnumerable);
        }



        [HttpGet]
        public ActionResult Create()
        {
            carregarCombo();
            return View();
        }

        private void carregarCombo()
        {
            ViewBag.inst = _IInstituicaoServico.ListarTudo();
            

        }

        [HttpPost]
        public ActionResult Create(Evento organizacoes)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    carregarCombo();
                    organizacoes.idArrecadado = _IArrecadadoServico.ObterPrimeiro().id;
                    _IEventoServico.Adicionar(organizacoes);

                }
                catch (Exception ex)
                {
                    carregarCombo();
                    ViewBag.msgErro = "Erro no cadastro. " + ex.Message.ToString();
                    return View(organizacoes);
                }
            }
            else
            {
                carregarCombo();
                return View(organizacoes);
            }
            
            return RedirectToAction("Details", new RouteValueDictionary(organizacoes));
        }
        public ActionResult Details(int id)
        {
            if (ModelState.IsValid)
            {
                Evento organizacoes = _IEventoServico.ObterPorID(id);
                return View(organizacoes);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                Evento organizacoes = _IEventoServico.ObterPorID(id);

                return View(organizacoes);
            }
            else
            {
                return HttpNotFound();
            }
        }



        [HttpPost]
        public ActionResult Edit(Evento organizacoes)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    //*** altera alvará.

                    _IEventoServico.Editar(organizacoes);
                }
                catch (Exception ex)
                {
                    ViewBag.msgErro = "Erro na Alteração. " + ex.Message.ToString();
                    return View(organizacoes);
                }
            }
            else
            {

                return View(organizacoes);
            }

            return RedirectToAction("Details", new RouteValueDictionary(organizacoes));
        }



        public ActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                //*** Exclui alvara
                var organizacoes = _IEventoServico.ObterPorID(id);
                _IEventoServico.Deletar(organizacoes);

                return RedirectToAction("Index", routeValues: new { id = id });
            }
            else
            {
                return HttpNotFound();
            }
        }
    }


}
