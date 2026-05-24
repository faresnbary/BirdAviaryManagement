namespace BirdAviaryManagement.Core.Models
{
    public class Bird
    {
        public string RingId { get; set; } = string.Empty;

        public BirdType Type { get; set; }

        public string ColorMutation { get; set; } = string.Empty;

        public int HatchYear { get; set; }

        public BirdStatus Status { get; set; }

        public bool IsAvailableForSale { get; set; }

        public bool IsBulkGenerated { get; set; }
    }
}