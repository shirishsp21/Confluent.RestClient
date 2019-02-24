using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Confluent.RestClient
{
    public interface IConfluentClientAuthentication
    {
        void ApplyAuthentication(HttpClient client);
    }
}
