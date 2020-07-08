using Repo.Applicant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Applicant;


namespace applicantform.Controllers
{
    public class ApplicantController : Controller
    {
        // GET: Applicant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (VMApplicant Applicant)
        {
            Boolean result = RepoApplicant.savedata(Applicant);

            if (result == true)
            {
                return Json(new { message = "Berhasil"}, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("Index", "Nasabah");
            }
            else
            {
                return Json(new { message = "Gagal", data = result }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("Index", "Applicant");
            }
        }

        public ActionResult Edit(long paramID)
        {
            return View(RepoApplicant.GetDetailsById(paramID));
        }

        // POST: ContactInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(VMApplicant paramModel)
        {
            bool result = false;
            if (result == true)
            {
                return Json(new { message = "Berhasil" }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("Index", "Daftar");
            }
            else
            {
                return Json(new { message = "Gagal" }, JsonRequestBehavior.AllowGet);
                //return RedirectToAction("Index", "Applicant");
            }
        }

        [HttpPost]
        public ActionResult Delete(long Daftar)
        {
            string result = RepoApplicant.HapusData(Daftar);
            if (result == "ok")
            {
                return RedirectToAction("Index", "Daftar");
            }
            else
            {
                return Json(new { message = "Gagal", data = result }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}