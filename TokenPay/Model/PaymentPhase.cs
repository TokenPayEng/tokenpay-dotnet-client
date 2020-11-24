using System.Runtime.Serialization;

namespace TokenPay.Model
{
    public enum PaymentPhase
    {
        [EnumMember(Value = "AUTH")] Auth
    }
}