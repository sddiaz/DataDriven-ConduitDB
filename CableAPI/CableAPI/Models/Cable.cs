namespace CableAPI.Models
{
    public class Cable
    {
        public string? ID { get; set; }
        public string? OtiGUID { get; set; }
        public string? PhaseValue { get; set; }
        public bool? InService { get; set; }
        public string? InServiceState { get; set; }
        public string? Description { get; set; }
        public string? Phase { get; set; }
        public int? NumberOfWires { get; set; }
        public string? FromBus { get; set; }
        public string? ToBus { get; set; }
        public int? Frequency { get; set; }
        public string? CA_ConductorType { get; set; }
        public string? CA_Installation { get; set; }
        public string? CA_RatedkV { get; set; }
        public string? CA_PercentClass { get; set; }
        public string? CA_Source { get; set; }
        public string? CA_Insulation { get; set; }
        public string? CA_NoofConductors { get; set; }
        public int? CabSize { get; set; }
        public string? CA_Length { get; set; }
        public string? CA_UnitSystem { get; set; }
        public string? CA_Temperature { get; set; }
        public string? CA_TemperatureCode { get; set; }
        public string? LengthValue { get; set; }
        public string? CableLengthUnit { get; set; }
        public string? Tolerance { get; set; }
        public int? MinTempValue { get; set; }
        public int? MaxTempValue { get; set; }
        public double? RPosValue { get; set; }
        public double? XPosValue { get; set; }
        public double? YPosValue { get; set; }
        public double? RZeroValue { get; set; }
        public double? XZeroValue { get; set; }
        public double? YZeroValue { get; set; }
        public double? ImpedanceUnits { get; set; }
        public double? OhmsPerLengthValue { get; set; }
        public double? OhmsPerLengthUnit { get; set; }
        public string? CommentText { get; set; }
        public string? CableVoltage { get; set; }
        public DateTime? Created_Date { get; set; }
        public string? CableNumber { get; set; }
        public string? LoadValue { get; set; }
        public string? LibraryLengthUnit { get; set; }
        public string? LibraryLength { get; set; }
        public string? State { get; set; }
        public int? GroundWireSize { get; set; }
        public int? CableSize { get; set; }
        public string? VoltageLevel { get; set; }
        public int? WireConnection { get; set; }

        public Cable() { }

        public Cable(
            string id, string phaseValue, bool inService, string inServiceState,
            string description, string phase, int numberOfWires, string fromBus,
            string toBus, int frequency, string caConductorType, string caInstallation,
            string caRatedkV, string caPercentClass, string caSource, string caInsulation,
            string caNoofConductors, int cabSize, int cableSize, string caLength, string caUnitSystem,
            string caTemperature, string caTemperatureCode, string lengthValue,
            string cableLengthUnit, string tolerance, int minTempValue, int maxTempValue,
            double rPosValue, double xPosValue, double yPosValue, double rZeroValue,
            double xZeroValue, double yZeroValue, double impedanceUnits,
            double ohmsPerLengthValue, double ohmsPerLengthUnit, int groundWireSize,
            string commentText, string cableVoltage, string voltageLevel,
            string otiGuid, string cableNumber,
            string loadValue, string libraryLengthUnit, string libraryLength,
            string state, DateTime? created_Date = null, int? wireConnection = null)
        {
            ID = id;
            OtiGUID = otiGuid;
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
            CableVoltage = cableVoltage;
            Created_Date = created_Date ?? DateTime.Now;
            CableNumber = cableNumber;
            LoadValue = loadValue;
            LibraryLengthUnit = libraryLengthUnit;
            LibraryLength = libraryLength;
            State = state;
            GroundWireSize = groundWireSize;
            CableSize = cableSize;
            VoltageLevel = voltageLevel;
            WireConnection = wireConnection;
        }
    }
}
