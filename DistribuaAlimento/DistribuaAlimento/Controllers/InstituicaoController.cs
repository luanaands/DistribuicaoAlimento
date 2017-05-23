using DistribuaAlimento.Models;
using DistribuaAlimento.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DistribuaAlimento.Controllers
{
    public class InstituicaoController : Controller
    {

        public IInstituicaoServico _IInstituicaoServico { get; set; }

        // GET: Instituicao
        public ActionResult Index()
        {

            IEnumerable<Instituicao> _alvaraIEnumerable = Enumerable.Empty<Instituicao>();
            _alvaraIEnumerable = _IInstituicaoServico.ListarTudo();
            return View(_alvaraIEnumerable);
        }

        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Instituicao instituicao)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Contexto contexto = new Contexto();
                    //contexto.Instituicao.Add(instituicao);
                    //contexto.SaveChanges();
                    _IInstituicaoServico.Adicionar(instituicao);
                }
                catch (Exception ex)
                {
                   
                    ViewBag.msgErro = "Erro no cadastro. " + ex.Message.ToString();
                    return View(instituicao);
                }
            }
            else
            {
                
                return View(instituicao);
            }

            return RedirectToAction("Details", new RouteValueDictionary(instituicao));
         }

        public ActionResult Details(int id)
        {
            if (ModelState.IsValid)
            {
                Instituicao instituicao = _IInstituicaoServico.ObterPorID(id);
                return View(instituicao);
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
                Instituicao instituicao = _IInstituicaoServico.ObterPorID(id);

                return View(instituicao);
            }
            else
            {
                return HttpNotFound();
            }
        }
        [HttpPost]
        public ActionResult Edit(Instituicao instituicao)
        { 

            if (ModelState.IsValid)
            {
                try
                {
                    //*** altera alvará.

                    _IInstituicaoServico.Editar(instituicao);
                }
                catch (Exception ex)
                {
                    ViewBag.msgErro = "Erro na Alteração. " + ex.Message.ToString();
                    return View(instituicao);
                }
            }
            else
            {
                
                return View(instituicao);
            }

            return RedirectToAction("Details", new RouteValueDictionary(instituicao));
        }

        public ActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                //*** Exclui alvara
                var instituicao = _IInstituicaoServico.ObterPorID(id);
                _IInstituicaoServico.Deletar(instituicao);

                return RedirectToAction("Index", routeValues: new { id = id});
            }
            else
            {
                return HttpNotFound();
            }
        }
    }

}