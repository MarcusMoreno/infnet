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
    public class PerguntaController : Controller
    {
        private ReviewEntities db = new ReviewEntities();

        // GET: Pergunta
        public ActionResult Index()
        {
            return View(db.Perguntas.ToList());

           
        }

        // GET: Pergunta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pergunta pergunta = db.Perguntas.Find(id);
            if (pergunta == null)
            {
                return HttpNotFound();
            }
            return View(pergunta);
        }

        // GET: Pergunta/Create
        public ActionResult Create()
        {
            ViewBag.TipoResposta = new SelectList(db.TipoRespostas.ToList().Select(g => g.DescricaoTipoResposta));
            
            return View();
        }

        // POST: Pergunta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pergunta pergunta, FormCollection form)
        {
            if (ModelState.IsValid)
            {
                //pergunta.TipoResposta.Add(ViewBag.TipoResposta);
                db.Perguntas.Add(pergunta);

                //Cria uma string com os valores passados no dropdown
                string u = form["TipoResposta"].ToString();

                //Quebra a string pegando os valores separados por ,
                var l = u.Split(',');

                foreach (var item in l)
                {
                    //Busca no banco os dados daquele tipo de resposta
                    var i = db.TipoRespostas.Select(f => f.DescricaoTipoResposta == item);

                    // Cria um objeto perguntaTipoResposta para ser adicionado no banco
                    PerguntaTipoResposta g =  new PerguntaTipoResposta();
                    g.IdPergunta = pergunta.IdPergunta;
                    g.IdtipoResposta = 9 ;

                    //Adiciona no banco
                    db.PerguntaTipoRespostas.Add(g);
                }
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pergunta);
        }

        // POST: Pergunta/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateList(string pergunta)
        {
            List<string> t = new List<string>();
            t.Add(pergunta);

           return View(pergunta);
        }


        // GET: Pergunta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pergunta pergunta = db.Perguntas.Find(id);
            if (pergunta == null)
            {
                return HttpNotFound();
            }
            return View(pergunta);
        }

        // POST: Pergunta/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdPergunta,DescricaoPergunta,PerguntaStatus")] Pergunta pergunta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pergunta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pergunta);
        }

        // GET: Pergunta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pergunta pergunta = db.Perguntas.Find(id);
            if (pergunta == null)
            {
                return HttpNotFound();
            }
            return View(pergunta);
        }

        // POST: Pergunta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pergunta pergunta = db.Perguntas.Find(id);
            db.Perguntas.Remove(pergunta);
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
