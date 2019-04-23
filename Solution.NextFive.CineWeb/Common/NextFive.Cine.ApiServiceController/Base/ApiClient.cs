using NextFive.Cine.Common.JSON;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace NextFive.Cine.ApiServiceController.Base
{
    public abstract class ApiClient
    {
        public ApiClient()
        {
            var _USER = "DBUENO";
            var _PASS = "123456";

            _CREDENCIALES = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", _USER, _PASS)));
            this.JsonManager = new JsonManager();
        }

        public T CallService<T>(Dictionary<string, string> HttpData, string httpVerb, string httpMethod, object TData = null) where T : new()
        {
            var _URI = HttpData["URI"];
            var _REQUEST_URI = HttpData["ReqURI"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_URI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _CREDENCIALES);

                var response = this.SendRequest(client, httpVerb, string.Concat(_REQUEST_URI, httpMethod), TData);
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<T>().Result;
                }
                else
                {
                    return new T();
                }
            }
        }
        private HttpResponseMessage SendRequest<T>(HttpClient client, string httpVerb, string requestUri, T data)
        {
            var _BDATA = JsonManager.CreateBinaryData(data);

            HttpResponseMessage response = new HttpResponseMessage();
            switch (httpVerb)
            {
                case HttpVerbs.POST:
                    response = client.PostAsJsonAsync(requestUri, _BDATA).Result;
                    break;
                case HttpVerbs.GET:
                    if (data != null)
                    {
                        string dataB64 = JsonManager.CreateStringB64FromData(data);
                        response = client.GetAsync(string.Concat(requestUri, "?jsonB64=", dataB64)).Result;
                    }
                    else
                    {
                        response = client.GetAsync(requestUri).Result;
                    }
                    break;
                case HttpVerbs.PUT:         //UPDATE
                    response = client.PutAsJsonAsync(requestUri, _BDATA).Result;
                    break;
                case HttpVerbs.DELETE:
                    break;
            }
            return response;
        }


        private string _CREDENCIALES { get; set; }
        public IJsonManager JsonManager { get; private set; }
    }
}

struct HttpVerbs
{
    public const string GET = "GET";
    public const string POST = "POST";
    public const string PUT = "PUT";
    public const string DELETE = "DELETE";
}