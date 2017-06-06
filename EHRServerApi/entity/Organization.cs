using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHRServerApi.entity
{
    public class Organization
    {
        [DeserializeAs(Name = "uid")]
        public string Uid { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }
    }
}
