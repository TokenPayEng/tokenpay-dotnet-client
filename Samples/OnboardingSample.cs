using System;
using System.Collections.Generic;
using NUnit.Framework;
using TokenPay;
using TokenPay.Model;
using TokenPay.Request;

namespace Samples
{
    public class OnboardingSample
    {
        private readonly TokenPayClient _tokenPayClient =
            new TokenPayClient("api-key", "secret-key", "https://api-gateway.tokenpay.com.tr");

        [Test]
        public void Create_Sub_Merchant()
        {
            var request = new CreateSubMerchantRequest
            {
                ContactName = "Haluk",
                ContactSurname = "Demir",
                Email = "haluk.demir@example.com",
                GsmNumber = "905551111111",
                Iban = "TR930006701000000001111111",
                IdentityNumber = "11111111110",
                LegalCompanyTitle = "Dem Zeytinyağı Üretim Ltd. Şti.",
                Name = "Dem Zeytinyağı Üretim Ltd. Şti.",
                SubMerchantExternalId = Guid.NewGuid().ToString(),
                SubMerchantType = SubMerchantType.LimitedOrJointStockCompany,
                TaxNumber = "1111111114",
                TaxOffice = "Erenköy",
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul"
            };

            var response = _tokenPayClient.Onboarding().CreateSubMerchant(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.ContactName, response.ContactName);
            Assert.AreEqual(request.ContactSurname, response.ContactSurname);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.GsmNumber, response.GsmNumber);
            Assert.AreEqual(request.Iban, response.Iban);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
            Assert.AreEqual(request.LegalCompanyTitle, response.LegalCompanyTitle);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.SubMerchantExternalId, response.SubMerchantExternalId);
            Assert.AreEqual(request.SubMerchantType, response.SubMerchantType);
            Assert.AreEqual(request.TaxNumber, response.TaxNumber);
            Assert.AreEqual(request.TaxOffice, response.TaxOffice);
            Assert.AreEqual(request.Address, response.Address);
        }

        [Test]
        public void Update_Sub_Merchant()
        {
            var subMerchantId = 1L;

            var request = new UpdateSubMerchantRequest
            {
                ContactName = "Haluk",
                ContactSurname = "Demir",
                Email = "haluk.demir@example.com",
                GsmNumber = "905551111111",
                Iban = "TR930006701000000001111111",
                IdentityNumber = "11111111110",
                LegalCompanyTitle = "Dem Zeytinyağı Üretim Ltd. Şti.",
                Name = "Dem Zeytinyağı Üretim Ltd. Şti.",
                TaxNumber = "1111111114",
                TaxOffice = "Erenköy",
                Address = "Suadiye Mah. Örnek Cd. No:23, 34740 Kadıköy/İstanbul"
            };

            var response = _tokenPayClient.Onboarding().UpdateSubMerchant(subMerchantId, request);
            Assert.AreEqual(subMerchantId, response.Id);
            Assert.AreEqual(request.ContactName, response.ContactName);
            Assert.AreEqual(request.ContactSurname, response.ContactSurname);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.GsmNumber, response.GsmNumber);
            Assert.AreEqual(request.Iban, response.Iban);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
            Assert.AreEqual(request.LegalCompanyTitle, response.LegalCompanyTitle);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.TaxNumber, response.TaxNumber);
            Assert.AreEqual(request.TaxOffice, response.TaxOffice);
            Assert.AreEqual(request.Address, response.Address);
        }

        [Test]
        public void Retrieve_Sub_Merchant()
        {
            var subMerchantId = 1L;

            var response = _tokenPayClient.Onboarding().RetrieveSubMerchant(subMerchantId);
            Assert.AreEqual(subMerchantId, response.Id);
        }

        [Test]
        public void Search_Sub_Merchants()
        {
            var request = new SearchSubMerchantsRequest
            {
                Name = "Zeytinyağı Üretim",
                SubMerchantIds = new HashSet<long> {1, 2}
            };

            var response = _tokenPayClient.Onboarding().SearchSubMerchants(request);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Create_Buyer()
        {
            var request = new CreateBuyerRequest
            {
                BuyerExternalId = Guid.NewGuid().ToString(),
                Email = "haluk.demir@example.com",
                GsmNumber = "905551111111",
                Name = "Haluk",
                Surname = "Demir",
                IdentityNumber = "11111111110"
            };

            var response = _tokenPayClient.Onboarding().CreateBuyer(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.BuyerExternalId, response.BuyerExternalId);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.GsmNumber, response.GsmNumber);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.Surname, response.Surname);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
        }

        [Test]
        public void Update_Buyer()
        {
            long buyerId = 1;
            var request = new UpdateBuyerRequest
            {
                Email = "haluk.demir@example.com",
                GsmNumber = "905551111111",
                Name = "Haluk",
                Surname = "Demir",
                IdentityNumber = "11111111110"
            };

            var response = _tokenPayClient.Onboarding().UpdateBuyer(buyerId, request);
            Assert.AreEqual(buyerId, response.Id);
            Assert.AreEqual(request.Email, response.Email);
            Assert.AreEqual(request.GsmNumber, response.GsmNumber);
            Assert.AreEqual(request.Name, response.Name);
            Assert.AreEqual(request.Surname, response.Surname);
            Assert.AreEqual(request.IdentityNumber, response.IdentityNumber);
        }

        [Test]
        public void Retrieve_Buyer()
        {
            var buyerId = 1L;

            var response = _tokenPayClient.Onboarding().RetrieveBuyer(buyerId);
            Assert.AreEqual(buyerId, response.Id);
        }
        
        [Test]
        public void Search_Buyers()
        {
            var request = new SearchBuyersRequest()
            {
                Name = "Zeytinyağı Üretim"
            };

            var response = _tokenPayClient.Onboarding().SearchBuyers(request);
            Assert.NotNull(response);
        }
    }
}