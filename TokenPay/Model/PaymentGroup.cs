using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum PaymentGroup
    {
        [EnumMember(Value = "OTHER")] Other,

        [EnumMember(Value = "PRODUCT")] Product,

        [EnumMember(Value = "LISTING_OR_SUBSCRIPTION")] ListingOrSubscription,
        
        [EnumMember(Value = "SUBSCRIPTION")] Subscription
        
    }
}