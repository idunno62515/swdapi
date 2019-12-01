namespace SwdApp.Data.Dtos {

    public partial class OrderDetailPromotionMapping {
        public int Id { get; set; }

        public int OrderDetailId { get; set; }


        public string PromotionCode { get; set; }


        public string PromotionDetailCode { get; set; }

        public int MappingIndex { get; set; }

        public decimal? DiscountAmount { get; set; }

        public int? DiscountRate { get; set; }

        public int? TmpMappingId { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
    }
}
