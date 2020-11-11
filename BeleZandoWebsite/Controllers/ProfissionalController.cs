using BeleZando.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using X.PagedList;

namespace BeleZandoWebsite.Controllers
{
    public class ProfissionalController : Controller
    {
        private Context db = new Context();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Profissional profissional)
        {
            if (ModelState.IsValid)
            {     
                profissional.UltimaAtualizacaoProfissional = DateTime.UtcNow;                
                db.Profissional.Add(profissional);
                db.SaveChanges();
                Dispose();
                TempData[Constants.MessageAlert] = "Profissional Cadastrado com Sucesso!";
                return RedirectToAction("Index", "Inicio");
            }
            return View(profissional);
        }

        [HttpGet]
        public ActionResult Consult()
        {            
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult _ModalListProfissional()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult IframeModalListProfissional(int pagina = 1)
        {
            return View(db.Profissional.OrderBy(a => a.CodigoProfissional).ToPagedList(pagina, 5));
        }

        [HttpGet]
        public JsonResult SelecionarProfissional(int codigoProfissional)
        {
            Profissional profissional = db.Profissional.Find(codigoProfissional);
            return Json(profissional, JsonRequestBehavior.AllowGet);
        }
        
        [HttpGet]
        public ActionResult SearchProfissional(string CodigoProfissional)
        {
            string acaoProfissional = Request["AcaoProfissional"];

            if ((acaoProfissional == null) || (acaoProfissional == "") || (acaoProfissional == "undefined"))
            {
                TempData[Constants.MessageAlert] = "Não foi possível buscar o profissional ... Tente novamente!";
                return RedirectToAction("Consult", "Profissional");
            }
                

            if ((CodigoProfissional == null) || (CodigoProfissional == "") || (CodigoProfissional == "undefined"))
            {
                TempData[Constants.MessageAlert] = "Por favor preencha o código do Profissional!";
                return RedirectToAction("Consult", "Profissional");
            }
                
            Profissional profissional = db.Profissional.Find(Convert.ToInt32(CodigoProfissional));

            if (profissional == null)
            {
                TempData[Constants.MessageAlert] = "Profissional Inexistente ... Tente novamente!";
                return RedirectToAction("Consult", "Profissional");
            }
                

            switch (acaoProfissional)
            {
                case "Detalhes":
                    return View("Details",profissional);

                case "Editar":
                    return View("Edit", profissional);

                case "Excluir":
                    return View("Delete", profissional);

                default:
                    return View("Consult", "Profissional");
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
        public ActionResult Edit(Profissional profissional)
        {
            if (ModelState.IsValid)
            {
                profissional.UltimaAtualizacaoProfissional = DateTime.UtcNow;
                db.Entry(profissional).State = EntityState.Modified;
                db.SaveChanges();
                Dispose();
                TempData[Constants.MessageAlert] = "Profissional Alterado com Sucesso!";
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
        public ActionResult Delete(int CodigoProfissional)
        {            
            Profissional profissional = db.Profissional.Find(CodigoProfissional);
            db.Profissional.Remove(profissional);
            db.SaveChanges();
            Dispose();
            TempData[Constants.MessageAlert] = "Profissional Excluído com Sucesso!";
            return RedirectToAction("Index","Inicio");
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
