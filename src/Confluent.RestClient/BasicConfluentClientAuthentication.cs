using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Confluent.RestClient
{
    public class BasicConfluentClientAuthentication : IConfluentClientAuthentication
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public BasicConfluentClientAuthentication(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public void ApplyAuthentication(HttpClient client)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Encoder.EncodeTo64(String.Format("{0}:{1}", Username, Password)));
        }
    }
}
