using Business.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Business.Model
{
    public class ApiRequestData
    {
        public ApiRequestData(string host, params string[] pathing)
        {
            RequestUrl = host.Trim().Trim('/').Trim();
            foreach(var p in pathing ?? new string[0])
                RequestUrl += "/" + p;

            QueryParameters = new Dictionary<string, string>();
        }

        public string RequestUrl { get; set; }

        public IDictionary<string, string> QueryParameters { get; private set; }

        private string MountRequestUrl()
        {
            var result = RequestUrl;
            if (QueryParameters?.Any() ?? false)
            {
                result += "?";
                foreach (var parameter in QueryParameters)
                    result += string.Format("{0}={1}&", parameter.Key, parameter.Value);
            }

            return result;
        }
        
        public T CallApi<T>(ApiRequestMethod method, HttpContent postHttpContent = null)
        {
            switch (method)
            {
                case ApiRequestMethod.GET:
                    using(var client = new HttpClient())
                    {
                        var responseContent = client.GetAsync(MountRequestUrl()).Result.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<T>(responseContent.Result);
                    }

                default:
                case ApiRequestMethod.POST:
                    using (var client = new HttpClient())
                    {
                        var responseContent = client.PostAsync(MountRequestUrl(), postHttpContent).Result.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<T>(responseContent.Result);
                    }
            }
        }

        public void AddQueryParameter(string key, string value) => QueryParameters.Add(key, value);

    }
}
