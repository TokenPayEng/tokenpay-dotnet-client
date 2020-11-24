using TokenPay.Net;
using TokenPay.Request;
using TokenPay.Request.Common;
using TokenPay.Response;

namespace TokenPay.Adapter
{
    public class SettlementReportingAdapter : BaseAdapter
    {
        public SettlementReportingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public BouncedSubMerchantRowListResponse SearchBouncedSubMerchantRows(
            SearchBouncedSubMerchantRowsRequest searchBouncedSubMerchantRowsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchBouncedSubMerchantRowsRequest);
            var path = "/settlement-reporting/v1/settlement-file/bounced-sub-merchant-rows" + query;

            return RestClient.Get<BouncedSubMerchantRowListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PayoutCompletedTransactionListResponse SearchPayoutCompletedTransactions(
            SearchPayoutCompletedTransactionsRequest searchPayoutCompletedTransactionsRequest)
        {
            var queryParams = RequestQueryParamsBuilder.BuildQueryParam(searchPayoutCompletedTransactionsRequest);
            var path = "/settlement-reporting/v1/settlement-file/payout-completed-transactions" + queryParams;
            return RestClient.Get<PayoutCompletedTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}