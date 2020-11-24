using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum MerchantType
    {
        [EnumMember(Value = "MERCHANT")] Merchant,
        [EnumMember(Value = "SUB_MERCHANT")] SubMerchant
    }
}