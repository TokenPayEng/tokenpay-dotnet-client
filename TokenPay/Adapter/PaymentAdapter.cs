using TokenPay.Net;
using TokenPay.Request;
using TokenPay.Request.Common;
using TokenPay.Response;
using TokenPay.Response.Dto;

namespace TokenPay.Adapter
{
    public class PaymentAdapter : BaseAdapter
    {
        public PaymentAdapter(RequestOptions requestOptions) : base(requestOptions)
        {
        }

        public PaymentResponse CreatePayment(CreatePaymentRequest createPaymentRequest)
        {
            var path = "/payment/v1/card-payments";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(createPaymentRequest, path, RequestOptions),
                createPaymentRequest);
        }

        public PaymentDetailResponse RetrievePayment(long id)
        {
            var path = "/payment-reporting/v1/payments/" + id;
            return RestClient.Get<PaymentDetailResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentDetailListResponse SearchPayments(SearchPaymentsRequest searchPaymentsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentsRequest);
            var path = "/payment-reporting/v1/payments" + query;

            return RestClient.Get<PaymentDetailListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentTransactionApprovalListResponse ApprovePaymentTransactions(
            ApprovePaymentTransactionsRequest approvePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/approve";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(approvePaymentTransactionsRequest, path, RequestOptions),
                approvePaymentTransactionsRequest);
        }

        public PaymentTransactionApprovalListResponse DisapprovePaymentTransactions(
            DisapprovePaymentTransactionsRequest disapprovePaymentTransactionsRequest)
        {
            var path = "/payment/v1/payment-transactions/disapprove";
            return RestClient.Post<PaymentTransactionApprovalListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(disapprovePaymentTransactionsRequest, path, RequestOptions),
                disapprovePaymentTransactionsRequest);
        }

        public PaymentTransactionResponse UpdatePaymentTransaction(long id,
            UpdatePaymentTransactionRequest updatePaymentTransactionRequest)
        {
            var path = "/payment/v1/payment-transactions/" + id;
            return RestClient.Put<PaymentTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updatePaymentTransactionRequest, path, RequestOptions),
                updatePaymentTransactionRequest);
        }

        public InitThreeDSPaymentResponse Init3DSPayment(InitThreeDSPaymentRequest initThreeDSPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-init";
            return RestClient.Post<InitThreeDSPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initThreeDSPaymentRequest, path, RequestOptions),
                initThreeDSPaymentRequest);
        }

        public PaymentResponse Complete3DSPayment(CompleteThreeDSPaymentRequest completeThreeDsPaymentRequest)
        {
            var path = "/payment/v1/card-payments/3ds-complete";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(completeThreeDsPaymentRequest, path, RequestOptions),
                completeThreeDsPaymentRequest);
        }

        public InitCheckoutPaymentResponse InitCheckoutPayment(InitCheckoutPaymentRequest initCheckoutPaymentRequest)
        {
            var path = "/payment/v1/checkout-payments/init";
            return RestClient.Post<InitCheckoutPaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(initCheckoutPaymentRequest, path, RequestOptions),
                initCheckoutPaymentRequest);
        }

        public PaymentResponse RetrieveCheckoutPayment(string token)
        {
            var path = "/payment/v1/checkout-payments/" + token;
            return RestClient.Get<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentTransactionRefundResponse RefundPaymentTransaction(
            RefundPaymentTransactionRequest refundPaymentTransactionRequest)
        {
            var path = "/payment/v1/refund-transactions";
            return RestClient.Post<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentTransactionRequest, path, RequestOptions),
                refundPaymentTransactionRequest);
        }

        public PaymentTransactionRefundResponse RetrievePaymentTransactionRefund(long id)
        {
            var path = "/payment/v1/refund-transactions/" + id;
            return RestClient.Get<PaymentTransactionRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentTransactionRefundListResponse SearchPaymentTransactionRefunds(
            SearchPaymentTransactionRefundsRequest searchPaymentTransactionRefundsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchPaymentTransactionRefundsRequest);
            var path = "/payment/v1/refund-transactions" + query;

            return RestClient.Get<PaymentTransactionRefundListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentRefundResponse RefundPayment(RefundPaymentRequest refundPaymentRequest)
        {
            var path = "/payment/v1/refunds";
            return RestClient.Post<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(refundPaymentRequest, path, RequestOptions),
                refundPaymentRequest);
        }

        public PaymentRefundResponse RetrievePaymentRefund(long id)
        {
            var path = "/payment/v1/refunds/" + id;
            return RestClient.Get<PaymentRefundResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public CrossBookingTransactionResponse ReceiveMoney(
            CrossBookingRequest crossBookingRequest)
        {
            var path = "/payment/v1/cross-bookings/receive";
            return RestClient.Post<CrossBookingTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(crossBookingRequest, path, RequestOptions),
                crossBookingRequest);
        }

        public CrossBookingTransactionResponse SendMoney(CrossBookingRequest crossBookingRequest)
        {
            var path = "/payment/v1/cross-bookings/send";
            return RestClient.Post<CrossBookingTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(crossBookingRequest, path, RequestOptions),
                crossBookingRequest);
        }

        public CrossBookingTransactionResponse CancelCrossBooking(CancelCrossBookingRequest cancelCrossBookingRequest)
        {
            var path = "/payment/v1/cross-bookings/cancel";
            return RestClient.Post<CrossBookingTransactionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(cancelCrossBookingRequest, path, RequestOptions),
                cancelCrossBookingRequest);
        }

        public CrossBookingTransactionListResponse SearchCrossBookings(
            SearchCrossBookingsRequest searchCrossBookingsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchCrossBookingsRequest);
            var path = "/payment/v1/cross-bookings" + query;

            return RestClient.Get<CrossBookingTransactionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public void DeleteStoredCard(DeleteStoredCardRequest deleteStoredCardRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(deleteStoredCardRequest);
            var path = "/payment/v1/cards" + query;

            RestClient.Delete<object>(RequestOptions.BaseUrl + path, CreateHeaders(path, RequestOptions));
        }

        public StoredCardListResponse SearchStoredCards(SearchStoredCardsRequest searchStoredCardsRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(searchStoredCardsRequest);
            var path = "/payment/v1/cards" + query;

            return RestClient.Get<StoredCardListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public PaymentResponse PostAuthPayment(long paymentId, PostAuthPaymentRequest postAuthPaymentRequest)
        {
            var path = "/payment/v1/card-payments/" + paymentId + "/post-auth";
            return RestClient.Post<PaymentResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(postAuthPaymentRequest, path, RequestOptions), postAuthPaymentRequest);
        }

        public SubscriptionListResponse SearchSubscription(SubscriptionSearchRequest subscriptionSearchRequest)
        {
            var query = RequestQueryParamsBuilder.BuildQueryParam(subscriptionSearchRequest);
            var path = "/payment/v2/subscription" + query;
            return RestClient.Get<SubscriptionListResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public SubscriptionResponse RetrieveSubscription(long subscriptionId)
        {
            var path = "/payment/v2/subscription/" + subscriptionId;
            return RestClient.Get<SubscriptionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(path, RequestOptions));
        }

        public SubscriptionResponse UpdateSubscription(long id, UpdateSubscriptionRequest updateSubscriptionRequest)
        {
            var path = "/payment/v2/subscription/" + id;
            return RestClient.Put<SubscriptionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(updateSubscriptionRequest, path, RequestOptions),
                updateSubscriptionRequest);
        }
        
        public SubscriptionResponse RenewSubscription(SubscriptionRenewRequest subscriptionRenewRequest)
        {
            var path = "/payment/v2/subscription/" + "renew-subscription";
            return RestClient.Post<SubscriptionResponse>(RequestOptions.BaseUrl + path,
                CreateHeaders(subscriptionRenewRequest, path, RequestOptions),
                subscriptionRenewRequest);
        }
    }
}
