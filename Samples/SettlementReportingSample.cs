using System;
using NUnit.Framework;
using TokenPay;
using TokenPay.Model;
using TokenPay.Request;

namespace Samples
{
    public class SettlementReportingSample
    {
        private readonly TokenPay.TokenPay _tokenPay =
            new TokenPay.TokenPay("api-key", "secret-key", "https://api-gateway.tokenpay.com.tr");

        [Test]
        public void Search_Bounced_Sub_Merchant_Rows()
        {
            var request = new SearchBouncedSubMerchantRowsRequest
            {
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now
            };

            var response = _tokenPay.SettlementReportingAdapter().SearchBouncedSubMerchantRows(request);
            Assert.NotNull(response);
        }

        [Test]
        public void Search_Payout_Completed_Transactions()
        {
            var request = new SearchPayoutCompletedTransactionsRequest
            {
                SettlementFileId = 1,
                SettlementType = SettlementType.Settlement,
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now
            };

            var response = _tokenPay.SettlementReportingAdapter().SearchPayoutCompletedTransactions(request);
            Assert.NotNull(response);
        }
    }
}