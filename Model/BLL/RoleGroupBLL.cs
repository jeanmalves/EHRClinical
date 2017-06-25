using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BLL
{
    public static class RoleGroupBLL
    {
        public static List<RolesGroup> GetRolesGroup()
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                return db.RolesGroups.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static RolesGroup GetRoleGroupByRole(string role)
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var roleGroup = db.RolesGroups.FirstOrDefault(r => r.Role == role);
                return roleGroup;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
