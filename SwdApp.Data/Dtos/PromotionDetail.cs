namespace SwdApp.Data.Dtos {
    public partial class PromotionDetail
    {
        public int PromotionDetailID { get; set; }

        public string PromotionCode { get; set; }

        public string RegExCode { get; set; }

        public double? MinOrderAmount { get; set; }

        public double? MaxOrderAmount { get; set; }

        public string BuyProductCode { get; set; }

        public int? MinBuyQuantity { get; set; }

        public int? MaxBuyQuantity { get; set; }

        public string GiftProductCode { get; set; }

        public string PromotionDetailCode { get; set; }

        public int? GiftQuantity { get; set; }

        public decimal? DiscountAmount { get; set; }

        public int? DiscountRate { get; set; }

        public bool? Active { get; set; }

        public int? CollectionCode { get; set; }
    }
}
