using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public enum Roles
    {
        [Description("Administrador")]
        ADMIN = 1,
        [Description("Paciente")]
        PATIENT,
        [Description("Médico")]
        DOCTOR,
        [Description("Atendente")]
        ATENDENT
    }
}
