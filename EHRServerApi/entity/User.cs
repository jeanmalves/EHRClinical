using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHRServerApi.entity
{
    public class User
    {
        [DeserializeAs(Name = "username")]
        public string UserName { get; set; }

        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        [DeserializeAs(Name = "password")]
        public string Password { get; set; }

        [DeserializeAs(Name = "token")]
        public string Token { get; set; }

        public string Organization { get; set; }

        [DeserializeAs(Name = "organizations")]
        public List<Organization> Organizations { get; set; }
    }
}
