namespace TokenPay.Request.Dto
{
    public class PaymentPlan
    {
        public string Description { get; set; }
        public decimal? Price { set; get; }
        public int? PeriodType { get; set; }
        public int? NochargeDayCount { get; set; }
        public int? PaymentCount { get; set; }
    }
}