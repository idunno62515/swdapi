using System.ComponentModel.DataAnnotations.Schema;

namespace SwdApp.Data.Entities
{
    public partial class CategoryExtra
    {
        public int CategoryExtraId { get; set; }

        public int PrimaryCategoryCode { get; set; }

        public int ExtraCategoryCode { get; set; }

        public bool IsEnable { get; set; }
    }
}
