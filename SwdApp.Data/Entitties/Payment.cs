using System;

namespace SwdApp.Data.Dtos
{
    public partial class Payment
    {
        public int PaymentID { get; set; }

        public int OrderId { get; set; }

        public double Amount { get; set; }

        public string CurrencyCode { get; set; }

        public decimal FCAmount { get; set; }

        public string Notes { get; set; }

        public DateTime PayTime { get; set; }

        public int Status { get; set; }

        public int Type { get; set; }

        public string CardCode { get; set; }

        public string Code { get; set; }

        public bool? Active { get; set; }

        public string PaymentCode { get; set; }

        public string CustomerName { get; set; }

        public int? MembershipTypeId { get; set; }

    }
}
