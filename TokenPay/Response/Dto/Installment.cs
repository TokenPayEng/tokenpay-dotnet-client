using System.Collections.Generic;
using TokenPay.Model;
using TokenPay.Response.Dto;

namespace TokenPay.Response.Dto
{
    public class Installment
    {
        public string BinNumber { get; set; }
        public decimal? Price { get; set; }
        public CardType? CardType { get; set; }
        public CardAssociation? CardAssociation { get; set; }
        public string CardBrand { get; set; }
        public string BankName { get; set; }
        public long? BankCode { get; set; }
        public bool? Force3ds { get; set; }
        public bool? Commercial { get; set; }
        public List<InstallmentPriceDto> InstallmentPrices { get; set; }
    }
}