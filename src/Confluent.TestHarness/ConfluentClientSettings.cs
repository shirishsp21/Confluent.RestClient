using System;
using Confluent.RestClient;

namespace Confluent.TestHarness
{
    public class ConfluentClientSettings : IConfluentClientSettings
    {
        public ConfluentClientSettings(string kafkaBaseUrl, TimeSpan requestTimeout, IConfluentClientAuthentication authentication)
        {
            KafkaBaseUrl = kafkaBaseUrl;
            RequestTimeout = requestTimeout;
            Authentication = authentication;
        }

        public string KafkaBaseUrl { get; private set; }
        public TimeSpan RequestTimeout { get; private set; }
        public IConfluentClientAuthentication Authentication { get; private set; }
    }
}
