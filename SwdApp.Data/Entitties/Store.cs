using System;

namespace SwdApp.Data.Entities {
    public partial class Store
    {
        public int Id { get; set; }

        public int StoreCode { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Lat { get; set; }

        public string Lon { get; set; }

        public bool? isAvailable { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public DateTime? CreateDate { get; set; }

        public int Type { get; set; }

        public int? RoomRentMode { get; set; }

        public DateTime? ReportDate { get; set; }

        public string ShortName { get; set; }

        public bool IsUsed { get; set; }
    }
}
