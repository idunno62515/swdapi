namespace SwdApp.Data.Entities
{
    public partial class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int? Nationality { get; set; }

        public string Notes { get; set; }
    }
}
