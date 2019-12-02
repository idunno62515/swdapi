namespace SwdApp.Data.Entities {
    public partial class Category
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsDisplayed { get; set; }

        public bool IsUsed { get; set; }

        public int? IsExtra { get; set; }

        public string AdjustmentNote { get; set; }

        public string ImageFontAwsomeCss { get; set; }

        public int? ParentCateId { get; set; }

        public int? MasterCategory { get; set; }

        public string ShortName { get; set; }
    }
}
