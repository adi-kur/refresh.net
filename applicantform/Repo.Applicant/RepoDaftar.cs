using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Applicant;
using ViewModel.Applicant;
using System.Data.Entity;

namespace Repo.Applicant
{
    public class RepoDaftar
    {
        public static List<VMApplicant> GetListAll()
        {
            List<VMApplicant> result = new List<VMApplicant>();
            using (var db = new Model1())
            {
                var data = from x in db.TB_Applicant
                           where x.Is_Delete == false
                           select new VMApplicant
                           {
                               ID = x.ID,
                               Name = x.Name,
                               Email = x.Email,
                               Address = x.Address,
                               Contact_Number = x.Contact_Number,
                               Date_Of_Birth = x.Date_Of_Birth,
                               Major = x.Major,
                               Question = x.Question,
                               Is_Delete = x.Is_Delete,
                               Created_By = "System",
                               Created_On = DateTime.Now,
                               Modified_By = "System",
                               Modified_On = DateTime.Now
                           };
                result = data.ToList();
            }

            return result;
        }

        public static VMApplicant GetDataById(int Id)
        {
            VMApplicant result = new VMApplicant();

            using (var db = new Model1())
            {
                var data = from x in db.TB_Applicant
                           where x.ID == Id
                           select new VMApplicant
                           {
                               ID = x.ID,
                               Name = x.Name,
                               Email = x.Email,
                               Address = x.Address,
                               Contact_Number = x.Contact_Number,
                               Date_Of_Birth = x.Date_Of_Birth,
                               Major = x.Major,
                               Question = x.Question,
                               Is_Delete = x.Is_Delete,
                               Created_By = "System",
                               Created_On = DateTime.Now,
                               Modified_By = "System",
                               Modified_On = DateTime.Now
                           };
                result = data.FirstOrDefault();
            }
            return result;
        }

    }
}

