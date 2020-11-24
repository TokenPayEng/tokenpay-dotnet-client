using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum RefundDestinationType
    {
        [EnumMember(Value = "CARD")] Card,
        [EnumMember(Value = "WALLET")] Wallet
    }
}