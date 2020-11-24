using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using TokenPay.Exception;
using TokenPay.Request.Common;
using TokenPay.Response.Common;
using exception = System.Exception;

namespace TokenPay.Net
{
    public static class RestClient
    {
        private static readonly HttpClient HttpClient;

        static RestClient()
        {
            #if !NETSTANDARD1_3
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            #endif
            var handler = new HttpClientHandler {AllowAutoRedirect = false};
            HttpClient = new HttpClient(handler)
            {
                Timeout = TimeSpan.FromSeconds(120)
            };
        }

        public static T Get<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Get, headers, null);
        }

        public static T Post<T>(string url, Dictionary<string, string> headers, IRequest request)
        {
            return Exchange<T>(url, HttpMethod.Post, headers, request);
        }

        public static T Delete<T>(string url, Dictionary<string, string> headers)
        {
            return Exchange<T>(url, HttpMethod.Delete, headers, null);
        }

        public static T Put<T>(string url, Dictionary<string, string> headers, IRequest request)
        {
            return Exchange<T>(url, HttpMethod.Put, headers, request);
        }

        private static T Exchange<T>(string url, HttpMethod httpMethod, Dictionary<string, string> headers,
            IRequest request)
        {
            try
            {
                var requestMessage = new HttpRequestMessage
                {
                    Method = httpMethod,
                    RequestUri = new Uri(url),
                    Content = PrepareContent(request)
                };
                foreach (var header in headers) requestMessage.Headers.Add(header.Key, header.Value);
                var httpResponseMessage = HttpClient.SendAsync(requestMessage).Result;
                return HandleResponse<T>(httpResponseMessage);
            }
            catch (TokenPayException e)
            {
                throw e;
            }
            catch (exception e)
            {
                throw new TokenPayException(e);
            }
        }

        private static T HandleResponse<T>(HttpResponseMessage httpResponseMessage)
        {
            var apiResponse =
                JsonConvert.DeserializeObject<Response<T>>(httpResponseMessage.Content.ReadAsStringAsync().Result);

            if (apiResponse == null) return default;
            if (apiResponse.Errors != null)
            {
                var errorResponse = apiResponse.Errors;
                throw new TokenPayException(errorResponse.ErrorCode, errorResponse.ErrorDescription,
                    errorResponse.ErrorGroup);
            }

            return apiResponse.Data;
        }

        private static StringContent PrepareContent(IRequest request)
        {
            if (request == null) return null;
            var body = JsonConvert.SerializeObject(request);
            return new StringContent(body, Encoding.UTF8, "application/json");
        }
    }
}