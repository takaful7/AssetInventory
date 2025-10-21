using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class DeviceType : BaseEntity
    {
        public string TypeName { get; set; }
        public ICollection<DeviceModel> DeviceModels { get; set; } = new List<DeviceModel>();
    }
}
