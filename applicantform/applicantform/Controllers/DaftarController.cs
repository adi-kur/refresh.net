using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Applicant;
using Repo.Applicant;

namespace applicantform.Controllers
{
    public class DaftarController : Controller
    {
        // GET: Daftar
        public ActionResult Index()
        {
            List<VMApplicant> data = RepoDaftar.GetListAll();
            return View(data);

        }

    }
}