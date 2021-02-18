using TokenPay.Net;
using TokenPay.Request;
using TokenPay.Request.Common;
using TokenPay.Response;

namespace TokenPay.Adapter
{
    public class OnboardingAdapter : BaseAdapter
    {
        public OnboardingAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public SubMerchantResponse CreateSubMerchant(CreateSubMerchantRequest createSubMerchantRequest)
        {
            var path = "/onboarding/v1/sub-merchants";
            return RestClient.Post<SubMerchantResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createSubMerchantRequest, path, RequestOptions),
                createSubMerchantRequest);
        }

        public SubMerchantResponse UpdateSubMerchant(long id, UpdateSubMerchantRequest updateSubMerchantRequest)
        {
            var path = "/onboarding/v1/sub-merchants/" + id;
            return RestClient.Put<SubMerchantResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateSubMerchantRequest, path, RequestOptions),
                updateSubMerchantRequest);
        }

        public SubMerchantResponse RetrieveSubMerchant(long id)
        {
            var path = "/onboarding/v1/sub-merchants/" + id;
            return RestClient.Get<SubMerchantResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public SubMerchantListResponse SearchSubMerchants(SearchSubMerchantsRequest searchSubMerchantsRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchSubMerchantsRequest);
            var path = "/onboarding/v1/sub-merchants" + queryParam;
            return RestClient.Get<SubMerchantListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public BuyerResponse CreateBuyer(CreateBuyerRequest createBuyerRequest)
        {
            var path = "/onboarding/v1/buyers";
            return RestClient.Post<BuyerResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createBuyerRequest, path, RequestOptions),
                createBuyerRequest);
        }

        public BuyerResponse UpdateBuyer(long id, UpdateBuyerRequest updateBuyerRequest)
        {
            var path = "/onboarding/v1/buyers/" + id;
            return RestClient.Put<BuyerResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateBuyerRequest, path, RequestOptions),
                updateBuyerRequest);
        }

        public BuyerResponse RetrieveBuyer(long id)
        {
            var path = "/onboarding/v1/buyers/" + id;
            return RestClient.Get<BuyerResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }
        
        public BuyerListResponse SearchBuyers(SearchBuyersRequest searchBuyersRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchBuyersRequest);
            var path = "/onboarding/v1/buyers" + queryParam;
            return RestClient.Get<BuyerListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}