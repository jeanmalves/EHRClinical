using Model.DAO;
using System.Linq;

namespace Model.BLL
{
    public static class UserBLL
    {
        public static User GetUsers()
        {
            var user = new User();
            return user;
        }

        public static User Authenticate(User u)
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var user = db.Users
                              .Where(us => us.UserName == u.UserName)
                              .Where(us => us.Access == u.Access)
                              .Where(us => us.Password == u.Password)
                              .FirstOrDefault();
                return user;
            }
            catch (System.Exception)
            {
                throw;
            }

        }

    }
}
