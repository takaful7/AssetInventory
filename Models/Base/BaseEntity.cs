namespace AssetInventory.Models.Base
{
    public abstract class BaseEntity
    {
        public long Id { get; set; } = default!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
