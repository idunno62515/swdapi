namespace SwdApp.Data.Entities {

    public partial class ProductCollectMapping {
        public int Id { get; set; }

        public int? CollectionCode { get; set; }

        public string ProductCode { get; set; }

        public int? Active { get; set; }
    }
}
