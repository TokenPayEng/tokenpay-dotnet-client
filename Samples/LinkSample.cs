using System;
using NUnit.Framework;
using TokenPay;
using TokenPay.Model;
using TokenPay.Request;
using TokenPay.Response;

namespace Samples
{
    public class LinkSample
    {
        private readonly TokenPayClient _tokenPayClient =
            new TokenPayClient("api-key", "secret-key", "https://api-gateway.tokenpay.com.tr");

        [Test]
        public void Create_Link()
        {
            CreateLinkRequest createLinkRequest = new CreateLinkRequest
            {
                Name = "test link",
                Description = "Test Link for payment",
                Price = new decimal(10),
                Stock = 100,
                EnabledInstallments = "1,2,3,6",
                ExpireDate = DateTime.Now.AddYears(20)
            };


            LinkResponse link = _tokenPayClient.LinkAdapter().CreateLink(createLinkRequest);
            Assert.NotNull(link.Id);
        }

        [Test]
        public void Update_Link()
        {
            long id = 1;
            UpdateLinkRequest updateLinkRequest = new UpdateLinkRequest
            {
                Status = Status.Active,
                Name = "new test link",
                Description = "new Test Link for payment",
                Price = new decimal(10),
                Stock = 100,
                EnabledInstallments = "1,2,3",
                ExpireDate = DateTime.Now.AddYears(4)
            };

            LinkResponse link = _tokenPayClient.LinkAdapter().UpdateLink(id, updateLinkRequest);
            Assert.NotNull(link.Id);
        }

        [Test]
        public void Retrieve_Link()
        {
            long id = 1;

            LinkResponse link = _tokenPayClient.LinkAdapter().RetrieveLink(id);
            Assert.NotNull(link.Id);
        }

        [Test]
        public void Delete_Link()
        {
            long id = 60;

            _tokenPayClient.LinkAdapter().DeleteLink(id);
        }

        [Test]
        public void Search_Links()
        {
            SearchLinksRequest searchLinksRequest = new SearchLinksRequest
            {
                Name = "name",
                Token = "token",
                Status = Status.Active
            };

            var response = _tokenPayClient.LinkAdapter().SearchLinks(searchLinksRequest);
            Assert.NotNull(response);
            Assert.AreEqual(0, response.Size);
        }
    }
}