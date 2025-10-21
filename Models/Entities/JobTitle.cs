using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class JobTitle : BaseEntity
    {
        public string JobTitleName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
