using RestSharp.Authenticators;
using RestSharp;

namespace EHRServerApi
{
    public class EHRServerAuthenticator : IAuthenticator
    {
        private readonly string usernameKey;
        private readonly string username;
        private readonly string passwordKey;
        private readonly string password;
        private readonly string organizationKey;
        private readonly string organization;


        public EHRServerAuthenticator(
            string usernameKey, 
            string username,
            string passwordKey,
            string password,
            string organizationKey,
            string organization)
        {
            this.usernameKey = usernameKey;
            this.username = username;
            this.passwordKey = passwordKey;
            this.password = password;
            this.organizationKey = organizationKey;
            this.organization = organization;
        }
        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddParameter(usernameKey, username);
            request.AddParameter(passwordKey, password);
            request.AddParameter(organizationKey, organization);
        }
    }
}
