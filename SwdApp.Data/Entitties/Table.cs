using System;

namespace SwdApp.Data.Entities {
    [Serializable]
    public partial class Table
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Text { get; set; }

        public int? Status { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsCircle { get; set; }

        public int TableRow { get; set; }

        public int TableColumn { get; set; }

        public int SpanTableRow { get; set; }

        public int SpanTableColumn { get; set; }

        public int Floor { get; set; }

        public int? CurrentOrderId { get; set; }

        public DateTime? CurrentOrderDate { get; set; }

        public int? ForOrderType { get; set; }
    }
}
