using DistribuaAlimento.Models;
using DistribuaAlimento.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DistribuaAlimento.Controllers
{
    public class InstituicaoController : Controller
    {

        public IInstituicaoServico _IInstituicaoServico { get; set; }

        // GET: Instituicao
        public ActionResult Index()
        {


            return View();
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

            return RedirectToAction("Index"/*"Details", new RouteValueDictionary(alvara)*/);
        }

    }
}