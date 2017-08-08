using Model.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BLL
{
    public class DoctorBLL
    {
        public static List<Doctor> GetDoctors()
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var doctors = db.Doctors.Include(d => d.User);
                return doctors.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static Doctor GetDoctorById(int? id)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                Doctor doctor = db.Doctors.Find(id);

                return doctor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Doctor GetDoctorByUserId(int? userId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                Doctor doctor = db.Doctors.FirstOrDefault(d => d.UserId == userId);

                return doctor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool AddDoctor(Doctor doctor, User user)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var newUser = UserBLL.AddUser(user);

                doctor.UserId = newUser.Id;

                db.Doctors.Add(doctor);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool UpdateDoctor(Doctor doctor, User user = null)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var doc = db.Doctors.Find(doctor.Id);

                if (doc != null)
                {
                    doc.FirstName = doctor.FirstName;
                    doc.LastName = doctor.LastName;
                    doc.Birth = doctor.Birth;
                    doc.Sex = doctor.Sex;
                    doc.MedicId = doctor.MedicId;

                    if (user != null)
                    {
                        var updateUser = UserBLL.updateUser(user);
                    }

                    db.SaveChanges();
                    return true;

                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool DeleteDoctor(int id)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                Doctor doctor = db.Doctors.Find(id);
                db.Doctors.Remove(doctor);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
