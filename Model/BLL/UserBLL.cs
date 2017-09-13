using EHRServerApi;
using EHRServerApi.entity;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.BLL
{
    public static class UserBLL
    {
        public static List<DAO.User> GetUsers()
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                return db.Users.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static DAO.User GetUserById(int? id)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var user = db.Users.Find(id);

                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DAO.User GetUserByEmail(string email)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var user = db.Users.FirstOrDefault(u => u.Email == email);

                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DAO.User Authenticate(DAO.User u)
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var user = db.Users
                              .Where(us => us.UserName == u.UserName)
                              .Where(us => us.Password == u.Password)
                              .Where(us => us.RoleGroupID == u.RoleGroupID)
                              .Where(us => us.Status == 1)
                              .FirstOrDefault();
                return user;

                //EHRServer ehrServer = new EHRServer();
                //var user = ehrServer.Login(u.UserName, u.Password);

                //DAO.User userModel = new DAO.User();

                //userModel.UserName = user.UserName;
                //userModel.Email = user.Email;
                //userModel.Organization = user.Organization;
                //userModel.Token = user.Token;

                //return userModel;

            }
            catch (System.Exception)
            {
                throw;
            }

        }

        public static DAO.User AddUser(DAO.User user)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var newUser = db.Users.Add(user);
                db.SaveChanges();

                return newUser;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static bool updateUser(DAO.User user)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();
                
                var updateUser = db.Users.Find(user.Id);

                if (updateUser != null)
                {
                    updateUser.UserName = user.UserName;

                    if (!string.IsNullOrEmpty(user.Password))
                    {
                        updateUser.Password = user.Password;
                    }
                }
                
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
