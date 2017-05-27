using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHRServerApi
{
    public class WebService
    {
        protected static string baseUrl;
        protected static RestClient client;
        public string UserName { get; protected set; }
        public string Password { get; protected set; }

        public WebService(string url)
        {
            baseUrl = url;
            client = new RestClient(baseUrl);
        }
    }
}
