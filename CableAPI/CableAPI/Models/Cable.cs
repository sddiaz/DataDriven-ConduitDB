namespace CableAPI.Models
{
    public class Cable
    {
        public string? ID { get; set; } // Export/Import
        public string? PhaseValue { get; set; } // Export/Import
        public bool? InService { get; set; } // Export only
        public string? InServiceState { get; set; } // Export only
        public string? Description { get; set; } // Export/Import
        public string? Phase { get; set; } // Export only
        public int? NumberOfWires { get; set; } // Export only
        public string? FromBus { get; set; } // Export/Import
        public string? ToBus { get; set; } // Export/Import
        public int? Frequency { get; set; } // Export only
        public string? CA_ConductorType { get; set; } // Export only
        public string? CA_Installation { get; set; } // Export/Import
        public string? CA_RatedkV { get; set; } // Export/Import
        public string? CA_PercentClass { get; set; } // Export/Import
        public string? CA_Source { get; set; } // Export/Import
        public string? CA_Insulation { get; set; } // Export/Import
        public string? CA_NoofConductors { get; set; } // Export only
        public int? CabSize { get; set; } // Export/Import
        public string? CA_Length { get; set; } // Export/Import
        public string? CA_UnitSystem { get; set; } // Export only
        public string? CA_Temperature { get; set; } // Export only
        public string? CA_TemperatureCode { get; set; } // Export only
        public string? LengthValue { get; set; } // Export only
        public string? CableLengthUnit { get; set; } // Export/Import
        public string? Tolerance { get; set; } // Export only
        public int? MinTempValue { get; set; } // Export only
        public int? MaxTempValue { get; set; } // Export only
        public double? RPosValue { get; set; } // Export only
        public double? XPosValue { get; set; } // Export only
        public double? YPosValue { get; set; } // Export only
        public double? RZeroValue { get; set; } // Export only
        public double? XZeroValue { get; set; } // Export only
        public double? YZeroValue { get; set; } // Export only
        public double? ImpedanceUnits { get; set; } // Export only
        public double? OhmsPerLengthValue { get; set; } // Export only
        public double? OhmsPerLengthUnit { get; set; } // Export only
        public string? CommentText { get; set; } // Export/Import
        public string? OtiGUID { get; set; } // Export/Import

        public Cable() { }

        public Cable(
            string id, string phaseValue, bool inService, string inServiceState,
            string description, string phase, int numberOfWires, string fromBus,
            string toBus, int frequency, string caConductorType, string caInstallation,
            string caRatedkV, string caPercentClass, string caSource, string caInsulation,
            string caNoofConductors, int cabSize, string caLength, string caUnitSystem,
            string caTemperature, string caTemperatureCode, string lengthValue,
            string cableLengthUnit, string tolerance, int minTempValue, int maxTempValue,
            double rPosValue, double xPosValue, double yPosValue, double rZeroValue,
            double xZeroValue, double yZeroValue, double impedanceUnits,
            double ohmsPerLengthValue, double ohmsPerLengthUnit, string commentText,
            string otiGuid)
        {
            ID = id;
            PhaseValue = phaseValue;
            InService = inService;
            InServiceState = inServiceState;
            Description = description;
            Phase = phase;
            NumberOfWires = numberOfWires;
            FromBus = fromBus;
            ToBus = toBus;
            Frequency = frequency;
            CA_ConductorType = caConductorType;
            CA_Installation = caInstallation;
            CA_RatedkV = caRatedkV;
            CA_PercentClass = caPercentClass;
            CA_Source = caSource;
            CA_Insulation = caInsulation;
            CA_NoofConductors = caNoofConductors;
            CabSize = cabSize;
            CA_Length = caLength;
            CA_UnitSystem = caUnitSystem;
            CA_Temperature = caTemperature;
            CA_TemperatureCode = caTemperatureCode;
            LengthValue = lengthValue;
            CableLengthUnit = cableLengthUnit;
            Tolerance = tolerance;
            MinTempValue = minTempValue;
            MaxTempValue = maxTempValue;
            RPosValue = rPosValue;
            XPosValue = xPosValue;
            YPosValue = yPosValue;
            RZeroValue = rZeroValue;
            XZeroValue = xZeroValue;
            YZeroValue = yZeroValue;
            ImpedanceUnits = impedanceUnits;
            OhmsPerLengthValue = ohmsPerLengthValue;
            OhmsPerLengthUnit = ohmsPerLengthUnit;
            CommentText = commentText;
            OtiGUID = otiGuid;
        }
    }
}
