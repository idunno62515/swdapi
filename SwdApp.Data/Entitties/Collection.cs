using System.ComponentModel.DataAnnotations.Schema;

namespace SwdApp.Data.Entities
{
    public partial class Collection
    {
        public int Id { get; set; }

        public int? Code { get; set; }

        public int? Active { get; set; }
    }
}
