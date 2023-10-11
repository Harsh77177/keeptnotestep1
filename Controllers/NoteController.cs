using keepnote_step1.Repo;
using Keepnote_Step1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Keepnote_Step1.Controllers
{
    public class NoteController : Controller
    {
        private NoteRepository _repo;
        public NoteController(NoteRepository repo)
        {
            _repo = repo;
        }



        // GET: NoteController
        public ActionResult Index()
        {
            List<Notes> notes = _repo.GetNotes();
            // in mvc , when ypou want to send some value from controlle
            // to view we use viewbag , viewdata



            return View(notes);
        }



        // GET: NoteController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetNoteById(id));
        }



        // GET: NoteController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: NoteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Notes note)
        {
            try
            {
                _repo.AddNotes(note);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: NoteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetNoteById(id));
        }



        // POST: NoteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, string content)
        {
            try
            {
                _repo.EditNotes(id, content);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: NoteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repo.GetNoteById(id));
        }
        // POST: NoteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repo.DeleteNotes(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}