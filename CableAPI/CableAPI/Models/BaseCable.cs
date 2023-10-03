namespace CableAPI.Models
{
    public class BaseCable
    {
        public string? ID { get; set; } // Export/Import
        public string? OtiGUID { get; set; } // Export/Import
        public string? FromBus { get; set; } // Export/Import
        public string? ToBus { get; set; } // Export/Import
  
        public BaseCable() { }

        public BaseCable(string id, string otiGuid, string fromBus, string toBus)
        {
            ID = id;
            OtiGUID = otiGuid;
            FromBus = fromBus;
            ToBus = toBus;
        }

    }
}
