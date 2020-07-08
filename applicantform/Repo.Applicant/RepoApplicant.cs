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
    public class RepoApplicant
    {
        public static bool savedata(VMApplicant Applicant)
        {
            try
            {
                using (Model1 db = new Model1())
                {
                    TB_Applicant data = new TB_Applicant();
                    data.ID = Applicant.ID;
                    data.Name = Applicant.Name;
                    data.Email = Applicant.Email;
                    data.Contact_Number = Applicant.Contact_Number;
                    data.Date_Of_Birth = Applicant.Date_Of_Birth;
                    data.Address = Applicant.Address;
                    data.Major = Applicant.Major;
                    data.Question = Applicant.Question;
                    data.Is_Delete = false;
                    data.Created_By = "System";
                    data.Created_On = DateTime.Now;

                    db.TB_Applicant.Add(data);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public static VMApplicant GetDetailsById(long paramID)
        {
            VMApplicant result = new VMApplicant();

            using (var db = new Model1())
            {
                var query = from a in db.TB_Applicant
                            where a.ID == paramID
                            select new VMApplicant
                            {
                                ID = a.ID,
                                Name = a.Name,
                                Contact_Number = a.Contact_Number,
                                Email = a.Email,
                                Date_Of_Birth = a.Date_Of_Birth,
                                Address = a.Address,
                                Major = a.Major,
                                Question = a.Question,
                                Created_By = a.Created_By,
                                Created_On = a.Created_On,
                                Modified_By = a.Modified_By,
                                Modified_On = a.Modified_On,
                                Is_Delete = a.Is_Delete
                            };
                result = query.FirstOrDefault();
            }
            return result;
        }

        public static bool Ubah(VMApplicant paramModel)
        {

            try
            {
                using (var db = new Model1())
                {
                    TB_Applicant a = db.TB_Applicant.Where(x => x.ID == paramModel.ID).FirstOrDefault();

                    if (a != null)
                    {
                        a.Name = paramModel.Name;
                        a.Contact_Number = paramModel.Contact_Number;
                        a.Email = paramModel.Email;
                        a.Date_Of_Birth = paramModel.Date_Of_Birth;
                        a.Address = paramModel.Address;
                        a.Major = paramModel.Major;
                        a.Question = paramModel.Question;
                        a.Modified_By = paramModel.Modified_By;
                        a.Modified_On = paramModel.Modified_On;

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        public static string HapusData(long ID)

        {
            try
            {
                using (Model1 db = new Model1())
                {
                    TB_Applicant datalama = db.TB_Applicant.Where(a => a.ID == ID).FirstOrDefault();

                    datalama.Is_Delete = true;


                    db.SaveChanges();
                    return "ok";
                }

            }
            catch (Exception e)
            {
                return e.Message.ToString();
                throw;
            }
        }

    }
}
