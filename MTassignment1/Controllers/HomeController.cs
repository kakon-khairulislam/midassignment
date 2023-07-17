using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTassignment1.Models;
using System.Data.Entity;


namespace MTassignment1.Controllers
{
    public class HomeController : Controller
    {
        AllDataContext db = new AllDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult System()
        {
            return View();
        }
        [HttpPost]
        public ActionResult System(AllData A)
        {

            db.AllDatas.Add(A);
            int a = db.SaveChanges();
            if (a > 0)
            {
                //ViewBag.InsertMessage = "<script>alert('Data Inserted!')</script>";
                TempData["InsertMessage"] = "<script>alert('Data Inserted!')</script>";
                return RedirectToAction("Track");
                //ModelState.Clear();
            }
            else
            {
                ViewBag.InsertMessage = "<script>alert('Data Not Inserted!')</script>";
            }



            return View();
        }
        public ActionResult Track()
        {
            var data = db.AllDatas.ToList();
            return View(data);
        }
        public ActionResult Admin()
        {
            var data = db.AllDatas.ToList();
            return View(data);
        }
        public ActionResult Edit(int id)
        {
            var row = db.AllDatas.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(AllData s)
        {
            db.Entry(s).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.UpdateMessage = "<script>alert('Data Updated!')</script>";
                ModelState.Clear();
            }
           return RedirectToAction("Admin"); ;
        }
        public ActionResult Delete(int id)
        {
            var OrderID = db.AllDatas.Where(model => model.ID == id).FirstOrDefault();
            return View(OrderID);
        }
        [HttpPost]
        public ActionResult Delete(AllData s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["DeleteMessage"] = "<script>alert('Data Deleted!')</script>";

            }
            else
            {
                ViewBag.DeleteMessage = "<script>alert('Data not deleted!')</script>";

            }
            return RedirectToAction("Admin");
        }
    }
}