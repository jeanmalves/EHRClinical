using Model.BLL;
using System.Collections.Generic;

namespace Model.DAO
{
    public class RolesDictionary
    {
        private static RolesDictionary RolesDictionaryObj;
        private static Dictionary<int, string> rolesDictionary;

        public RolesDictionary()
        {
            rolesDictionary = new Dictionary<int, string>();

            var roles = RoleGroupBLL.GetRolesGroup();

            foreach (var role in roles)
            {
                rolesDictionary.Add(role.Id, role.Description);
            }
        }

        public static Dictionary<int, string> RoleList
        {
            get
            {
                if (rolesDictionary == null)
                {
                    RolesDictionaryObj = new RolesDictionary();
                }
                return rolesDictionary;
            }
        }

        public static string getValue(short key)
        {
            return RoleList.ContainsKey(key) ? RoleList[key] : "";
        }
    }
}
