using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeleZando.Models;
using X.PagedList;

namespace BeleZandoWebsite.Controllers
{
    public class AtendenteController : Controller
    {
        private Context db = new Context();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Atendente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.UltimaAtualizacaoAtendente = DateTime.UtcNow;
                db.Atendente.Add(cliente);
                db.SaveChanges();
                Dispose();
                TempData[Constants.MessageAlert] = "Atendente Cadastrado com Sucesso!";
                return RedirectToAction("Index", "Inicio");
            }
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Consult()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ModalListAtendente(int pagina = 1)
        {
            return View(db.Atendente.OrderBy(a => a.CodigoAtendente).ToPagedList(pagina, 5));
        }

        [HttpGet]
        public JsonResult SelecionarAtendente(int codigoAtendente)
        {
            Atendente profissional = db.Atendente.Find(codigoAtendente);
            return Json(profissional, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SearchAtendente(string CodigoAtendente)
        {
            string acaoAtendente = Request["AcaoAtendente"];

            if ((acaoAtendente == null) || (acaoAtendente == "") || (acaoAtendente == "undefined"))
            {
                TempData[Constants.MessageAlert] = "Não foi possível buscar o profissional ... Tente novamente!";
                return RedirectToAction("Consult", "Atendente");
            }


            if ((CodigoAtendente == null) || (CodigoAtendente == "") || (CodigoAtendente == "undefined"))
            {
                TempData[Constants.MessageAlert] = "Por favor preencha o código do Atendente!";
                return RedirectToAction("Consult", "Atendente");
            }

            Atendente profissional = db.Atendente.Find(Convert.ToInt32(CodigoAtendente));

            if (profissional == null)
            {
                TempData[Constants.MessageAlert] = "Atendente Inexistente ... Tente novamente!";
                return RedirectToAction("Consult", "Atendente");
            }


            switch (acaoAtendente)
            {
                case "Detalhes":
                    return View("Details", profissional);

                case "Editar":
                    return View("Edit", profissional);

                case "Excluir":
                    return View("Delete", profissional);

                default:
                    return View("Consult", "Atendente");
            }
        }

        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Atendente profissional)
        {
            if (ModelState.IsValid)
            {
                profissional.UltimaAtualizacaoAtendente = DateTime.UtcNow;
                db.Entry(profissional).State = EntityState.Modified;
                db.SaveChanges();
                Dispose();
                TempData[Constants.MessageAlert] = "Atendente Alterado com Sucesso!";
                return RedirectToAction("Index", "Inicio");
            }
            return View(profissional);
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int CodigoAtendente)
        {
            Atendente profissional = db.Atendente.Find(CodigoAtendente);
            db.Atendente.Remove(profissional);
            db.SaveChanges();
            Dispose();
            TempData[Constants.MessageAlert] = "Atendente Excluído com Sucesso!";
            return RedirectToAction("Index", "Inicio");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
