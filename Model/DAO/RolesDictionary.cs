using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class RolesDictionary
    {
        private static RolesDictionary RolesDictionaryObj;
        private static Dictionary<int, string> rolesDictionary;

        public RolesDictionary()
        {
            //Cursos atualmente ofertados nos processos de seleção à UTFPR
            rolesDictionary = new Dictionary<int, string>();
            rolesDictionary.Add((int) Roles.ADMIN, "Administrador");
            rolesDictionary.Add((int)Roles.PATIENT, "Paciente");
            rolesDictionary.Add((int)Roles.DOCTOR, "Médico");
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
    }
}
