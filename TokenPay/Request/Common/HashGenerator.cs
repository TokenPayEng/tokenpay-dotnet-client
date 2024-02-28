using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TokenPay.Exception;
using exception = System.Exception;

namespace TokenPay.Request.Common
{
    public static class HashGenerator
    {
        public static string GenerateHash(string baseUrl, string apiKey, string secretKey, string randomString,
            IRequest request, string path)
        {
            try
            {
                var hashData = "";

                var decodedUrl = Uri.UnescapeDataString(baseUrl + path);

                if (request != null)
                {
                    var requestBody = JsonConvert.SerializeObject(request, 
                                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                    hashData = decodedUrl + apiKey + secretKey + randomString + requestBody;
                }
                else
                {
                    hashData = decodedUrl + apiKey + secretKey + randomString;
                }

                HashAlgorithm algorithm = SHA256.Create();
                var hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashData));
                return Convert.ToBase64String(hash);
            }
            catch (exception e)
            {
                throw new TokenPayException(e);
            }
        }
    }
}