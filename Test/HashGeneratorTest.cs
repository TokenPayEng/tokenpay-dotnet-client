using NUnit.Framework;
using TokenPay.Request;
using TokenPay.Request.Common;

namespace Test
{
    public class HashGeneratorTest
    {
        [Test]
        public void Should_Generate_Hash()
        {
            //given
            var expectedSignature = "JCHNFH6WY4WMOUIYHEHSPPZ/YXJ/4+JHGGT9AEQE6TO=";
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
    }
}