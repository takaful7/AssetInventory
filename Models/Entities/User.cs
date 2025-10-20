using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }

        public long JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }

        public long CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
