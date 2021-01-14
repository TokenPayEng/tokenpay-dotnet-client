using System;
using System.Collections.Generic;
using NUnit.Framework;
using TokenPay;
using TokenPay.Model;
using TokenPay.Request;
using TokenPay.Request.Dto;

namespace Samples
{
    public class PaymentSample
    {
        private readonly TokenPayClient _tokenPayClient =
            new TokenPayClient("api-key", "secret-key", "https://api-gateway.tokenpay.com.tr");

        [Test]
        public void Create_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.ListingOrSubscription,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual(request.Currency, response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual(request.PaymentGroup, response.PaymentGroup);
            Assert.AreEqual(request.PaymentPhase, response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual(CardType.CreditCard, response.CardType);
            Assert.AreEqual(CardAssociation.MasterCard, response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }
        
        [Test]
        public void Create_Gateway_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.ListingOrSubscription,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                PosAlias = "62-YKB-1",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual(request.Currency, response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual(request.PaymentGroup, response.PaymentGroup);
            Assert.AreEqual(request.PaymentPhase, response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual(CardType.CreditCard, response.CardType);
            Assert.AreEqual(CardAssociation.MasterCard, response.CardAssociation);
            Assert.AreEqual(ConnectorType.TOKENGATE, response.ConnectorType);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Create_Marketplace_Payment()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.Product,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(27.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(42.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(18.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual(request.Currency, response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual(request.PaymentGroup, response.PaymentGroup);
            Assert.AreEqual(request.PaymentPhase, response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual(CardType.CreditCard, response.CardType);
            Assert.AreEqual(CardAssociation.MasterCard, response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.Null(response.CardUserKey);
            Assert.Null(response.CardToken);
        }

        [Test]
        public void Create_Payment_And_Store_Card()
        {
            var request = new CreatePaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.Product,
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000",
                    StoreCardAfterSuccessPayment = true,
                    CardAlias = "My YKB Card"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(27.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(42.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(18.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().CreatePayment(request);
            Assert.NotNull(response.Id);
            Assert.AreEqual(request.Price, response.Price);
            Assert.AreEqual(request.PaidPrice, response.PaidPrice);
            Assert.AreEqual(request.WalletPrice, response.WalletPrice);
            Assert.AreEqual(request.Currency, response.Currency);
            Assert.AreEqual(request.Installment, response.Installment);
            Assert.AreEqual(request.PaymentGroup, response.PaymentGroup);
            Assert.AreEqual(request.PaymentPhase, response.PaymentPhase);
            Assert.AreEqual(false, response.IsThreeDS);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRate);
            Assert.AreEqual(decimal.Zero, response.MerchantCommissionRateAmount);
            Assert.AreEqual(false, response.PaidWithStoredCard);
            Assert.AreEqual("525864", response.BinNumber);
            Assert.AreEqual("0001", response.LastFourDigits);
            Assert.AreEqual(CardType.CreditCard, response.CardType);
            Assert.AreEqual(CardAssociation.MasterCard, response.CardAssociation);
            Assert.AreEqual("World", response.CardBrand);
            Assert.AreEqual(3, response.PaymentTransactions.Count);
            Assert.NotNull(response.CardUserKey);
            Assert.NotNull(response.CardToken);
        }

        [Test]
        public void Init_3DS_Payment()
        {
            var request = new InitThreeDSPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.Product,
                CallbackUrl = "https://www.your-website.com/tokenpay-3DSecure-callback",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(27.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(42.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(18.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().Init3DSPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
        }
        
        [Test]
        public void Init_3DS_Gateway_Payment()
        {
            var request = new InitThreeDSPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.Product,
                CallbackUrl = "https://www.your-website.com/tokenpay-3DSecure-callback",
                Card = new Card
                {
                    CardHolderName = "Haluk Demir",
                    CardNumber = "5258640000000001",
                    ExpireYear = "2044",
                    ExpireMonth = "07",
                    Cvc = "000"
                },
                PosAlias = "62-YKB-1",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(27.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(42.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0),
                        SubMerchantId = 1,
                        SubMerchantPrice = new decimal(18.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().Init3DSPayment(request);
            Assert.NotNull(response);
            Assert.NotNull(response.HtmlContent);
            Assert.NotNull(response.GetDecodedHtmlContent());
        }

        [Test]
        public void Complete_3DS_Payment()
        {
            var request = new CompleteThreeDSPaymentRequest
            {
                PaymentId = 1
            };

            var response = _tokenPayClient.Payment().Complete3DSPayment(request);
            Assert.NotNull(response);
        }

        [Test]
        public void Init_Checkout_Payment()
        {
            var request = new InitCheckoutPaymentRequest
            {
                Price = new decimal(100.0),
                PaidPrice = new decimal(100.0),
                WalletPrice = new decimal(0.0),
                Installment = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                Currency = Currency.Try,
                PaymentGroup = PaymentGroup.ListingOrSubscription,
                CallbackUrl = "https://www.your-website.com/tokenpay-checkout-callback",
                CardUserKey = "eee24372-1735-4bc1-a534-023f1e02a03e",
                Items = new List<PaymentItem>
                {
                    new PaymentItem
                    {
                        Name = "Item 1",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(30.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 2",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(50.0)
                    },
                    new PaymentItem
                    {
                        Name = "Item 3",
                        ExternalId = Guid.NewGuid().ToString(),
                        Price = new decimal(20.0)
                    }
                }
            };

            var response = _tokenPayClient.Payment().InitCheckoutPayment(request);
            Assert.NotNull(response.Token);
            Assert.NotNull(response.PageUrl);
        }

        [Test]
        public void Retrieve_Checkout_Payment()
        {
            var token = "fe4b0c2d-3c48-4553-9429-695d204bd7c1";

            var response = _tokenPayClient.Payment().RetrieveCheckoutPayment(token);
            Assert.NotNull(response.Id);
        }


        [Test]
        public void Approve_Payment_Transactions()
        {
            var request = new ApprovePaymentTransactionsRequest
            {
                PaymentTransactionIds = new HashSet<long> {1, 2},
                IsTransactional = true
            };

            var response = _tokenPayClient.Payment().ApprovePaymentTransactions(request);
            Assert.NotNull(response);
            Assert.AreEqual(2, response.Size);
        }

        [Test]
        public void Disapprove_Payment_Transactions()
        {
            var request = new DisapprovePaymentTransactionsRequest
            {
                PaymentTransactionIds = new HashSet<long> {1, 2},
                IsTransactional = true
            };

            var response = _tokenPayClient.Payment().DisapprovePaymentTransactions(request);
            Assert.NotNull(response);
            Assert.AreEqual(2, response.Size);
        }

        [Test]
        public void Retrieve_Payment()
        {
            long paymentId = 1;

            var response = _tokenPayClient.Payment().RetrievePayment(paymentId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentId, response.Id);
        }

        [Test]
        public void Search_Payments()
        {
            var request = new SearchPaymentsRequest
            {
                Currency = Currency.Try,
                PaymentStatus = PaymentStatus.Success
            };

            var response = _tokenPayClient.Payment().SearchPayments(request);
            Assert.NotNull(response);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Refund_Payment()
        {
            var request = new RefundPaymentRequest
            {
                PaymentId = 1,
                RefundDestinationType = RefundDestinationType.Card
            };

            var response = _tokenPayClient.Payment().RefundPayment(request);
            Assert.NotNull(response);
            Assert.AreEqual(request.PaymentId, response.PaymentId);
            Assert.AreEqual(RefundStatus.Success, response.Status);
        }

        [Test]
        public void Retrieve_Payment_Refund()
        {
            long paymentRefundId = 1;

            var response = _tokenPayClient.Payment().RetrievePaymentRefund(paymentRefundId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentRefundId, response.Id);
        }

        [Test]
        public void Refund_Payment_Transaction()
        {
            var request = new RefundPaymentTransactionRequest
            {
                PaymentTransactionId = 1,
                ConversationId = "456d1297-908e-4bd6-a13b-4be31a6e47d5",
                RefundPrice = 20,
                RefundDestinationType = RefundDestinationType.Card
            };

            var response = _tokenPayClient.Payment().RefundPaymentTransaction(request);
            Assert.NotNull(response);
            Assert.AreEqual(request.PaymentTransactionId, response.PaymentTransactionId);
            Assert.AreEqual(RefundStatus.Success, response.Status);
        }

        [Test]
        public void Retrieve_Payment_Transaction_Refund()
        {
            long paymentTransactionRefundId = 1;

            var response = _tokenPayClient.Payment().RetrievePaymentTransactionRefund(paymentTransactionRefundId);
            Assert.NotNull(response);
            Assert.AreEqual(paymentTransactionRefundId, response.Id);
            Assert.AreEqual(RefundStatus.Success, response.Status);
        }

        [Test]
        public void Search_Payment_Transaction_Refunds()
        {
            var request = new SearchPaymentTransactionRefundsRequest
            {
                PaymentId = 1
            };

            var response = _tokenPayClient.Payment().SearchPaymentTransactionRefunds(request);
            Assert.NotNull(response);
            Assert.True(response.Items.Count > 0);
        }

        [Test]
        public void Delete_StoredCard()
        {
            var request = new DeleteStoredCardRequest
            {
                CardToken = "fac377f2-ab15-4696-88d2-5e71b27ec378",
                CardUserKey = "11a078c4-3c32-4796-90b1-51ee5517a212"
            };
            Assert.DoesNotThrow(() => _tokenPayClient.Payment().DeleteStoredCard(request));
        }

        [Test]
        public void Search_Stored_Cards()
        {
            var request = new SearchStoredCardsRequest
            {
                CardAlias = "My YKB Card",
                CardBankName = "YAPI VE KREDİ BANKASI A.Ş.",
                CardBrand = "World",
                CardAssociation = CardAssociation.MasterCard,
                CardToken = "d9b19d1a-243c-43dc-a498-add08162df72",
                CardUserKey = "c115ecdf-0afc-4d83-8a1b-719c2af19cbd",
                CardType = CardType.CreditCard
            };

            var response = _tokenPayClient.Payment().SearchStoredCards(request);
            Assert.NotNull(response);
            Assert.True(response.Items.Count > 0);
        }
    }
}