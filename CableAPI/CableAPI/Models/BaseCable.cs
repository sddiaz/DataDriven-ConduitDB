namespace CableAPI.Models
{
    public class BaseCable
    {
        public string? ID { get; set; } // Export/Import
        public string? OtiGUID { get; set; } // Export/Import
        public string? FromBus { get; set; } // Export/Import
        public string? ToBus { get; set; } // Export/Import

        public DateTime? Created_Date { get; }

        public BaseCable() { }

        public BaseCable(string id, string otiGuid, string fromBus, string toBus, DateTime created_Date)
        {
            ID = id;
            OtiGUID = otiGuid;
            FromBus = fromBus;
            ToBus = toBus;
            Created_Date = created_Date;
        }

    }
}