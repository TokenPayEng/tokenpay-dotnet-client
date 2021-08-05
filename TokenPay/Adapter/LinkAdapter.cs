using TokenPay.Net;
using TokenPay.Request;
using TokenPay.Request.Common;
using TokenPay.Response;

namespace TokenPay.Adapter
{
    public class LinkAdapter : BaseAdapter
    {
        public LinkAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public LinkResponse CreateLink(CreateLinkRequest createLinkRequest)
        {
            var path = "/tokenlink/v1/products";
            return RestClient.Post<LinkResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createLinkRequest, path, RequestOptions), createLinkRequest);
        }

        public LinkResponse UpdateLink(long id, UpdateLinkRequest updateLinkRequest)
        {
            var path = "/tokenlink/v1/products/" + id;
            return RestClient.Put<LinkResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateLinkRequest, path, RequestOptions), updateLinkRequest);
        }

        public LinkResponse RetrieveLink(long id)
        {
            var path = "/tokenlink/v1/products/" + id;
            return RestClient.Get<LinkResponse>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public void DeleteLink(long id)
        {
            var path = "/tokenlink/v1/products/" + id;
            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public LinkListResponse SearchLinks(SearchLinksRequest searchLinksRequest)
        {
            var queryParam = RequestQueryParamsBuilder.BuildQueryParam(searchLinksRequest);
            var path = "/tokenlink/v1/products?" + queryParam;
            return RestClient.Get<LinkListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }
    }
}