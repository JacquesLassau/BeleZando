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
    public class ClienteController : Controller
    {
        private Context db = new Context();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.UltimaAtualizacaoCliente = DateTime.UtcNow;
                db.Cliente.Add(cliente);
                db.SaveChanges();
                Dispose();
                TempData[Constants.MessageAlert] = "Cliente Cadastrado com Sucesso!";
                return RedirectToAction("Index", "Inicio");
            }
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Consult(int pagina = 1)
        {
            return View((db.Cliente.OrderBy(a => a.CodigoCliente).ToPagedList(pagina, 5)));
        }

        [HttpGet]
        public PartialViewResult ModalListCliente()
        {
            return PartialView();
        }


        [HttpGet]
        public JsonResult SelecionarCliente(int codigoCliente)
        {
            Cliente profissional = db.Cliente.Find(codigoCliente);
            return Json(profissional, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SearchCliente(string CodigoCliente)
        {
            string acaoCliente = Request["AcaoCliente"];

            if ((acaoCliente == null) || (acaoCliente == "") || (acaoCliente == "undefined"))
            {
                TempData[Constants.MessageAlert] = "Não foi possível buscar o profissional ... Tente novamente!";
                return RedirectToAction("Consult", "Cliente");
            }


            if ((CodigoCliente == null) || (CodigoCliente == "") || (CodigoCliente == "undefined"))
            {
                TempData[Constants.MessageAlert] = "Por favor preencha o código do Cliente!";
                return RedirectToAction("Consult", "Cliente");
            }

            Cliente profissional = db.Cliente.Find(Convert.ToInt32(CodigoCliente));

            if (profissional == null)
            {
                TempData[Constants.MessageAlert] = "Cliente Inexistente ... Tente novamente!";
                return RedirectToAction("Consult", "Cliente");
            }


            switch (acaoCliente)
            {
                case "Detalhes":
                    return View("Details", profissional);

                case "Editar":
                    return View("Edit", profissional);

                case "Excluir":
                    return View("Delete", profissional);

                default:
                    return View("Consult", "Cliente");
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
        public ActionResult Edit(Cliente profissional)
        {
            if (ModelState.IsValid)
            {
                profissional.UltimaAtualizacaoCliente = DateTime.UtcNow;
                db.Entry(profissional).State = EntityState.Modified;
                db.SaveChanges();
                Dispose();
                TempData[Constants.MessageAlert] = "Cliente Alterado com Sucesso!";
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
        public ActionResult Delete(int CodigoCliente)
        {
            Cliente profissional = db.Cliente.Find(CodigoCliente);
            db.Cliente.Remove(profissional);
            db.SaveChanges();
            Dispose();
            TempData[Constants.MessageAlert] = "Cliente Excluído com Sucesso!";
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
