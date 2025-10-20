using AssetInventory.Models.Base;
using AssetInventory.Models.Histories;

namespace AssetInventory.Models.Entities
{
    public class Asset : BaseEntity
    {
        public string AssetNumber { get; set; } = default!;

        public long CompanyId { get; set; }

        public Company Company { get; set; } = default!;

        public long DeviceModelId { get; set; }

        public DeviceModel DeviceModel {get; set; } = default!;

        public string SerialNumber { get; set; }

        public string Specification { get; set; }

        public long LocationId { get; set; }

        public Location Location { get; set; }

        public long ConditionId { get; set; }

        public Condition Condition { get; set; }

        public string? DetailCondition { get; set; }

        public long StatusId { get; set; }

        public Status Status { get; set; }

        public long? UserId { get; set; }

        public User User { get; set; }

        public ICollection<AssetAssignmentHistory> AssignmentHistories { get; set; } = new List<AssetAssignmentHistory>();

        public ICollection<AssetLocationHistory> LocationHistories { get; set; } = new List<AssetLocationHistory>();

        public ICollection<AssetConditionHistory> ConditionHistories { get; set; } = new List<AssetConditionHistory>();

        public ICollection<AssetStatusHistory> StatusHistories { get; set; } = new List<AssetStatusHistory>();
    }
}
