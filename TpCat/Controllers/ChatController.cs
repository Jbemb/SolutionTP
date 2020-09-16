using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TpCat.Data;
using TpCat.Models;

namespace TpCat.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            List<Chat> CatList = FakeDb.Instance.ListeChats;
          
            return View(CatList);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            Chat cat = FakeDb.Instance.ListeChats.FirstOrDefault(x => x.Id ==id);
            return View(cat);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            Chat cat = FakeDb.Instance.ListeChats.FirstOrDefault(x => x.Id == id);
            return View(cat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Chat cat = FakeDb.Instance.ListeChats.FirstOrDefault(x => x.Id == id);
                FakeDb.Instance.ListeChats.Remove(cat);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
