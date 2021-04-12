using System;
using System.Net;

namespace Atheny
{
    public class PolleryClient : WebClient
    {
        public PolleryClient() { }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address) as HttpWebRequest;
            request.UserAgent = "Pollery-Client";

            return request;
        }
    }
}
