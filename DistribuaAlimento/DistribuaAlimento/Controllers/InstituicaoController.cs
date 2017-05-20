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
            IEnumerable<Instituicao> instituicao = Enumerable.Empty<Instituicao>();

            instituicao = from a in _IInstituicaoServico.ListarTudo()
                          select a;

            return View(instituicao);
        }

        public ActionResult Teste()
        {
            Instituicao instituicao;


            instituicao = new Instituicao()
            {

                razaosocial = "rafaela",
                nomeRepresentante = "luana",
                telefone = "992391375",
                email = "luana@",
                cnpj = "000000"


            };
            Contexto contexto = new Contexto();
            contexto.Instituicao.Add(instituicao);
           


            return RedirectToAction("Index");
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
                    //*** cadastra alvara
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

            return RedirectToAction("Index");
        }


    }
}