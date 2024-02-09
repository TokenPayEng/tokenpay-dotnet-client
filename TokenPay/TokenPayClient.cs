using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using TokenPay.Adapter;
using TokenPay.Request.Common;

namespace TokenPay
{
    public class TokenPayClient
    {
        private const string BaseUrl = "https://api-gateway.tokenpay.com.tr";
        private readonly InstallmentAdapter _installmentAdapter;
        private readonly OnboardingAdapter _onboardingAdapter;
        private readonly PaymentAdapter _paymentAdapter;
        private readonly SettlementReportingAdapter _settlementReportingAdapter;
        private readonly LinkAdapter _linkAdapter;

        public TokenPayClient(string apiKey, string secretKey)
            : this(apiKey, secretKey, BaseUrl)
        {
        }

        public TokenPayClient(string apiKey, string secretKey, string baseUrl)
        {
            ConfigureJsonConverter();

            var requestOptions = new RequestOptions
            {
                ApiKey = apiKey,
                SecretKey = secretKey,
                BaseUrl = baseUrl
            };

            _paymentAdapter = new PaymentAdapter(requestOptions);
            _installmentAdapter = new InstallmentAdapter(requestOptions);
            _onboardingAdapter = new OnboardingAdapter(requestOptions);
            _settlementReportingAdapter = new SettlementReportingAdapter(requestOptions);
            _linkAdapter = new LinkAdapter(requestOptions);
        }

        public PaymentAdapter Payment()
        {
            return _paymentAdapter;
        }

        public InstallmentAdapter Installment()
        {
            return _installmentAdapter;
        }

        public OnboardingAdapter Onboarding()
        {
            return _onboardingAdapter;
        }

        public SettlementReportingAdapter SettlementReportingAdapter()
        {
            return _settlementReportingAdapter;
        }

        public LinkAdapter LinkAdapter()
        {
            return _linkAdapter;
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