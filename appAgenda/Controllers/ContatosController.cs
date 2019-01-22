using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repository.Context;
using appAgenda.ViewModels.Agenda;
using Repository.Repository;
using Repository.Models;
using Repository.Interface;

namespace appAgenda.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
    
        public ContatosController()
        {
            _contatoRepository = new ContatoRepository(new ContextMain());
        }
        // GET: ContatoViewModels
        public ActionResult Index()
        {
            return View(_contatoRepository.ObterTodos());
        }

        // GET: ContatoViewModels/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Contato contato = _contatoRepository.ObterPorId(id);

            ContatoViewModel contatoViewModel = null;
            {
                return HttpNotFound();
            }
            return View(contatoViewModel);
        }

        // GET: ContatoViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContatoViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdContato,Nome,Endereco,Empresa,Ativo")] ContatoViewModel contatoViewModel)
        {
            if (ModelState.IsValid)
            {
                contatoViewModel.IdContato = Guid.NewGuid();
                //arrumar
                _contatoRepository.Adicionar(null);
                _contatoRepository.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contatoViewModel);
        }

        // GET: ContatoViewModels/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Contato contato = _contatoRepository.ObterPorId(id);
            
            ContatoViewModel contatoViewModel = null; //db.ContatoViewModels.Find(id);

            if (contatoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(contatoViewModel);
        }

        // POST: ContatoViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdContato,Nome,Endereco,Empresa,Ativo")] ContatoViewModel contatoViewModel)
        {
            if (ModelState.IsValid)
            {
                Contato contato = null;
                _contatoRepository.Atualizar(contato);
                _contatoRepository.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(contatoViewModel);
        }

        // GET: ContatoViewModels/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Contato contato = _contatoRepository.ObterPorId(id);

            ContatoViewModel contatoViewModel = null;

            if (contatoViewModel == null)
            {
                return HttpNotFound();
            }

            return View(contatoViewModel);
        }

        // POST: ContatoViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Contato contaoto = _contatoRepository.ObterPorId(id);

            _contatoRepository.Remover(id);
            _contatoRepository.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _contatoRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
