using AssetInventory.Models.Entities;

namespace AssetInventory.Models.Base
{
    public abstract class BaseHistoryEntity
    {
        public long Id { get; set; }

        public long AssetId { get; set; }

        public Asset Asset { get; set; }

        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        public long? AdminId { get; set; } //ChangedBy < diubah oleh?

        public Admin Admin { get; set; }

        public string? Notes { get; set; }
    }
}
