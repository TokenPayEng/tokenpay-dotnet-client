using TokenPay.Net;
using TokenPay.Request;
using TokenPay.Request.Common;
using TokenPay.Response;

namespace TokenPay.Adapter
{
    public class InstallmentAdapter : BaseAdapter
    {
        public InstallmentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public InstallmentListResponse SearchInstallments(SearchInstallmentsRequest searchInstallmentsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchInstallmentsRequest);
            var path = "/installment/v1/installments" + queryParam;
            return RestClient.Get<InstallmentListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public BinNumberResponse RetrieveBinNumber(string binNumber)
        {
            var path = "/installment/v1/bins/" + binNumber;
            return RestClient.Get<BinNumberResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}