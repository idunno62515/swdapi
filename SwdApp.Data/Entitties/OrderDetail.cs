using System;

namespace SwdApp.Data.Dtos
{
   

    public partial class OrderDetail
    {

        public int OrderDetailID { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public double FinalAmount { get; set; }

        public double TotalAmount { get; set; }

        public double Discount { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; }

        public int Status { get; set; }

        public string Notes { get; set; }

        public double? TaxValue { get; set; }

        public double UnitPrice { get; set; }

        public int? ProductType { get; set; }

        public int? ParentId { get; set; }

        public int ProductOrderType { get; set; }

        public int ItemQuantity { get; set; }

        public int OrderGroup { get; set; }

        public int? TmpDetailId { get; set; }

        public string PromotionCode { get; set; }

        public int? OrderPromotionMappingId { get; set; }

        public int? OrderDetailPromotionMappingId { get; set; }

        public bool? Active { get; set; }

        public string Code { get; set; }

        public int? PrintGroup { get; set; }


    }
}
