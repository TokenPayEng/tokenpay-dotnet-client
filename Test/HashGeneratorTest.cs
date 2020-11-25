using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using TokenPay.Request;
using TokenPay.Request.Common;

namespace Test
{
    public class HashGeneratorTest
    {
        [SetUp]
        public void Setup()
        {
            ConfigureJsonConverter();
        }

        [Test]
        public void Should_Generate_Hash()
        {
            //given
            var expectedSignature = "JAIELEQK7VZ4LJDB9UOWYVIYAM0H5DWJGFJDC5EV4Y4=";
            var request = new CreateBuyerRequest
            {
                BuyerExternalId = "ext-1511",
                Email = "haluk.demir@example.com",
                GsmNumber = "905551111111",
                Name = "Haluk",
                Surname = "Demir",
                IdentityNumber = "11111111110"
            };

            //when
            var signature = HashGenerator.GenerateHash("http://api-gateway.tokenpay.com.tr", "api-key", "secret-key",
                "rand-2010",
                request, "/onboarding/v1/buyers");

            //then
            Assert.AreEqual(expectedSignature, signature);
        }

        [Test]
        public void Should_Generate_Hash_When_Request_Body_Null()
        {
            //given
            var expectedSignature = "YRF3CBLVJP9TFHTR9NWSMZPV91HIBPZXJT88NDEWXIK=";

            //when
            var signature = HashGenerator.GenerateHash("http://api-gateway.tokenpay.com.tr", "api-key", "secret-key",
                "rand-2010",
                null, "/onboarding/v1/buyers");

            //then
            Assert.AreEqual(expectedSignature, signature);
        }

        private static void ConfigureJsonConverter()
        {
            JsonConvert.DefaultSettings = () =>
            {
                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    Converters = new List<JsonConverter>
                    {
                        new StringEnumConverter()
                    }
                };
                return settings;
            };
        }
    }
}