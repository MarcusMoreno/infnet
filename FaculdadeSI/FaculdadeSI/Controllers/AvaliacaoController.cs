using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FaculdadeSI.Models;

namespace FaculdadeSI.Controllers
{
    public class AvaliacaoController : Controller
    {
        private ReviewEntities db = new ReviewEntities();

        // GET: Avaliacao
        public ActionResult Index()
        {
            var avaliacaos = db.Avaliacaos.Include(a => a.Perfil).Include(a => a.Usuario);
            return View(avaliacaos.ToList());
        }

        // GET: Avaliacao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            if (avaliacao == null)
            {
                return HttpNotFound();
            }
            return View(avaliacao);
        }

        // GET: Avaliacao/Create
        public ActionResult Create()
        {
            ViewBag.IdPerfil = new SelectList(db.Perfils, "IdPerfil", "DescricaoPerfil");
            ViewBag.IdUsuario = new SelectList(db.Usuarios, "IdUsuario", "Nome");
            return View();
        }

        // POST: Avaliacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAvaliacao,DescricaoAvaliacao,Expiracao,Titulo,IdUsuario,IdPerfil,AvaliacaoStatus")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                db.Avaliacaos.Add(avaliacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPerfil = new SelectList(db.Perfils, "IdPerfil", "DescricaoPerfil", avaliacao.IdPerfil);
            ViewBag.IdUsuario = new SelectList(db.Usuarios, "IdUsuario", "Nome", avaliacao.IdUsuario);
            return View(avaliacao);
        }

        // GET: Avaliacao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            if (avaliacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPerfil = new SelectList(db.Perfils, "IdPerfil", "DescricaoPerfil", avaliacao.IdPerfil);
            ViewBag.IdUsuario = new SelectList(db.Usuarios, "IdUsuario", "Nome", avaliacao.IdUsuario);
            return View(avaliacao);
        }

        // POST: Avaliacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAvaliacao,DescricaoAvaliacao,Expiracao,Titulo,IdUsuario,IdPerfil,AvaliacaoStatus")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(avaliacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPerfil = new SelectList(db.Perfils, "IdPerfil", "DescricaoPerfil", avaliacao.IdPerfil);
            ViewBag.IdUsuario = new SelectList(db.Usuarios, "IdUsuario", "Nome", avaliacao.IdUsuario);
            return View(avaliacao);
        }

        // GET: Avaliacao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            if (avaliacao == null)
            {
                return HttpNotFound();
            }
            return View(avaliacao);
        }

        // POST: Avaliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Avaliacao avaliacao = db.Avaliacaos.Find(id);
            db.Avaliacaos.Remove(avaliacao);
            db.SaveChanges();
            return RedirectToAction("Index");
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
