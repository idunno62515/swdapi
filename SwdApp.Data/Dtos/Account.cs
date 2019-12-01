namespace SwdApp.Data.Dtos {
    public partial class Account {
        public string AccountId { get; set; }

        public string AccountPassword { get; set; }

        public string StaffName { get; set; }

        public string Role { get; set; }

        public bool IsUsed { get; set; }
    }
}
