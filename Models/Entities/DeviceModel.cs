using AssetInventory.Models.Base;

namespace AssetInventory.Models.Entities
{
    public class DeviceModel : BaseEntity
    {
        public long DeviceTypeId { get; set; }

        public DeviceType DeviceType { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }
    }
}
