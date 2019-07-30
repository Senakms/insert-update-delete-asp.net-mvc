using project01.Models;
using project01.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        Db1Entities db = new Db1Entities();


        public ActionResult Index()
        {
            List<Table> kayitListe = db.Table.ToList();
            return View(kayitListe);
        }
        public ActionResult newRecord()
        {
            return View();
        }


        [HttpPost]
        public ActionResult newRecord(recorModel model)
        {
            Table record = new Table();
            record.NameSurname = model.NameSurname;
            record.Email = model.Email;
            record.Age = model.Age;
            record.Gsm = model.Gsm;
            record.Address = model.Address;
            record.City = model.City;
            db.Table.Add(record);
            db.SaveChanges();
            ViewBag.result = "Record is done!";
            return View();
        }

        public ActionResult deleteRecord(int? id)
        {
            Table record = db.Table.Where(k => k.Id == id).SingleOrDefault();
            db.Table.Remove(record);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult updateRecord(int? id)
        {
            Table record = db.Table.Where(k => k.Id == id).SingleOrDefault();
            recorModel model = new recorModel();
            model.Id = record.Id;
            model.NameSurname = record.NameSurname;
            model.Email = record.Email;
            model.Age = record.Age;
            model.Gsm = record.Gsm;
            model.Address = record.Address;
            model.City = record.City;

            return View(model);
        }


        [HttpPost]
        public ActionResult updateRecord(recorModel m)
        {
            Table record = db.Table.Where(k => k.Id == m.Id).SingleOrDefault();
            record.NameSurname = m.NameSurname;
            record.Email = m.Email;
            record.Age = m.Age;
            record.Address = m.Address;
            record.City = m.City;
            db.SaveChanges();
            ViewBag.result = "Record is updated!";
            return View();
        }

    }
}