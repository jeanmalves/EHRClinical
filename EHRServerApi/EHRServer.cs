using EHRServerApi.entity;
using RestSharp;

namespace EHRServerApi
{
    public class EHRServer : WebService, IWebService
    {
        private static string organization = "684795";
        public EHRServer() : base("https://cabolabs-ehrserver.rhcloud.com/rest") { }

        public User Login(string userName, string password)
        {
            UserName = userName;
            Password = password;

            client.Authenticator = new EHRServerAuthenticator("username", UserName, "password", Password, "organization", organization);
            
            RestRequest request = new RestRequest("login", Method.POST);
            
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute<User>(request);

            User user = new User();

            if (response.ErrorException != null)
            {
                // ajustar
                return user;
            }

            user = GetProfile(UserName, response.Data.Token);

            if (user != null)
            {
                user.Token = response.Data.Token;
                user.Organization = user.Organizations                        
                                        .Find(a => a.Uid == "4698e7e5-fb6a-4e07-b6c9-024c76419bd5")
                                        .Name;
                return user;
            }

            return response.Data;
            
        }

        public User GetProfile(string userName, string token )
        {
            RestRequest request = new RestRequest("profile/" + userName, Method.GET);

            request.AddHeader("Authorization", token);

            request.RequestFormat = DataFormat.Json;

            var response = client.Execute<User>(request);

            if (response.ErrorException != null)
            {
                // ajustar
                return new User(); ;
            }

            return response.Data;
        }
    }
}
