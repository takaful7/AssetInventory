namespace AssetInventory.Models
{
    public class Assets
    {
        public int Id { get; set; }

        public string AssetNumber { get; set; }

        public int CompanyId { get; set; }

        public int DeviceModelId { get; set; }

        public string SerialNumber { get; set; }

        public string Specification { get; set; }

        public int LocationId { get; set; }

        public int ConditionId { get; set; }

        public string DetailCondition { get; set; }

        public int StatusId { get; set; }

        public int UserId { get; set; }

        public Date MyProperty { get; set; }
    }
}
