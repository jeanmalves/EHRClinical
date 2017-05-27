using Model.DAO;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHRServerApi
{
    public class EHRServer : WebService, IWebService
    {
        private static string organization = "684795";
        public EHRServer(User user) : base("https://cabolabs-ehrserver.rhcloud.com/rest")
        {
            UserName = user.UserName;
            Password = user.Password;
        }

        public string Login()
        {
            client.Authenticator = new EHRServerAuthenticator("username", UserName, "password", Password, "organization", organization);
            
            RestRequest request = new RestRequest("login", Method.POST);
            
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute<User>(request);
            return "token";
        }
    }
}
