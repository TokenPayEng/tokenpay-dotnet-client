# TokenPay Dotnet Client

![TokenPay Dotnet CI](https://github.com/craftbaseio/tokenpay-dotnet-client/workflows/TokenPay%20Dotnet%20CI/badge.svg)

![Nuget](https://img.shields.io/nuget/v/TokenPay)

This repo contains the Dotnet client for TokenPay API.

## Requirements
- .NET Framework 4.6+
- .NET Core 1.1+ 
- .NET Core 2.0+

## Installation
```bash

```

## Usage
To access the TokenPay API you'll first need to obtain API credentials (e.g. an API key and a secret key). If you don't already have a TokenPay account, you can signup at [https://tokenpay.com.tr/](https://tokenpay.com.tr)

Once you've obtained your API credentials, you can start using TokenPay by instantiating a `TokenPayClient` with your credentials.

```dotnet

TokenPayClient _tokenPayClient = new TokenPayClient("<YOUR API KEY>", "<YOUR SECRET KEY>");
...

```

By default the TokenPay client connects to the production API servers at `https://api.tokenpay.com.tr`. For testing purposes, please use the sandbox URL `https://sandbox-api.tokenpay.com.tr` using the .

```java

TokenPayClient _tokenPayClient = new TokenPayClient("<YOUR API KEY>", "<YOUR SECRET KEY>", "https://sandbox-api.tokenpay.com.tr");
...

```

## Examples
Included in the project are a number of examples that cover almost all use-cases. Refer to [the `Samples/` folder](./Samples)] for more info.

### Running the Examples
If you've cloned this repo on your development machine and wish to run the examples you can run an example with the command `dotnet test` or run single test with the command `dotnet test --filter Name~Create_Payment`

### Credit Card Payment Use Case
Let's quickly review an example where we implement a credit card payment scenario.

> For more examples covering almost all use-cases, check out the [examples in the `Samples/` folder](./Samples)

```dotnet
TokenPayClient _tokenPayClient = new TokenPayClient("<YOUR API KEY>", "<YOUR SECRET KEY>");

var request = new CreatePaymentRequest
{
    Price = new decimal(100.0),
    PaidPrice = new decimal(100.0),
    WalletPrice = new decimal(0.0),
    Installment = 1,
    ConversationId = "foo-bar",
    Currency = CurrencyCode.Try,
    PaymentGroup = PaymentGroup.Product,
    Card = new CardDto
    {
        CardHolderName = "Ahmet Mehmet",
        CardNumber = "5406670000000009",
        ExpireYear = "2035",
        ExpireMonth = "11",
        Cvc = "123"
    },
    Items = new List<CreatePaymentItemDto>
    {
        new CreatePaymentItemDto
        {
            Name = "Item 1",
            Price = new decimal(30.0),
            SubMerchantId = 1,
            SubMerchantPrice = new decimal(27.0)
        },
        new CreatePaymentItemDto
        {
            Name = "Item 2",
            Price = new decimal(50.0),
            SubMerchantId = 1,
            SubMerchantPrice = new decimal(42.0)
        },
        new CreatePaymentItemDto
        {
            Name = "Sanitizer",
            Price = new decimal(20.0),
            SubMerchantId = 1,
            SubMerchantPrice = new decimal(18.0)
        }
    }
};

var response = _tokenPayClient.Payment().CreatePayment(request);
Assert.NotNull(response);
```

### Advanced Usage: Adapters
In reality, the `TokenPayCient` class serves as a collection of adapters that integrates with different parts of the API. While the intended usage for most use-cases is to instantiate a `TokenPay` instance (as illustrated in the examples above) and use its adapter accessors (e.g. `payment()`), you can also manually import a certain adapter class and instantiate it.

**Note:** When instantiating an adapter, you can use the same options as you would when instantiating a `TokenPayClient`

For all adapters in the `TokenPayClient`, their purposes, accessors, as well as direct import paths, refer to the list below:

| Adapter Name | Purpose | Accessor |
|--------------|---------|----------|
| `InstallmentAdapter` | Retrieving per-installment pricing information based on installment count or BIN number | `Installment()` |
| `OnboardingAdapter` | Conducting CRUD operations on buyers and submerchants | `Onboarding()` |
| `PaymentAdapter` | Conducting payments, retrieving payment information, managing stored cards | `Payment()` |
| `SettlementReportingAdapter` | Retrieving information on settlements | `SettlementReporting()` |

## License
MIT
