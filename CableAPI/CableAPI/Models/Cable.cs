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
        public int? GroundWireSize { get; set; }
        public int? CableSize { get; set; }
        public string? VoltageLevel { get; set; }

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
            string otiGuid, DateTime? created_Date = null)
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
            GroundWireSize = groundWireSize;
            CableSize = cableSize;
            VoltageLevel = voltageLevel;
        }
    }
}
// QUERY to create table. 
//--Recreate the table with the specified schema
//CREATE TABLE Cable (
//    ID nvarchar(255) NOT NULL,
//    OtiGUID nvarchar(255) CHECK(OtiGUID IS NOT NULL),
//    PhaseValue nvarchar(255) CHECK(PhaseValue IS NOT NULL),
//    InService bit CHECK (InService IN (0, 1)),
//    InServiceState nvarchar(255) CHECK(InServiceState IS NOT NULL),
//    Description nvarchar(255) CHECK(Description IS NOT NULL),
//    Phase nvarchar(255) CHECK(Phase IS NOT NULL),
//    NumberOfWires int CHECK(NumberOfWires IS NOT NULL),
//    FromBus nvarchar(255) CHECK(FromBus IS NOT NULL),
//    ToBus nvarchar(255) CHECK(ToBus IS NOT NULL),
//    Frequency int CHECK(Frequency IS NOT NULL),
//    CA_ConductorType nvarchar(255) CHECK(CA_ConductorType IS NOT NULL),
//    CA_Installation nvarchar(255) CHECK(CA_Installation IS NOT NULL),
//    CA_RatedkV nvarchar(255) CHECK(CA_RatedkV IS NOT NULL),
//    CA_PercentClass nvarchar(255) CHECK(CA_PercentClass IS NOT NULL),
//    CA_Source nvarchar(255) CHECK(CA_Source IS NOT NULL),
//    CA_Insulation nvarchar(255) CHECK(CA_Insulation IS NOT NULL),
//    CA_NoofConductors nvarchar(255) CHECK(CA_NoofConductors IS NOT NULL),
//    CabSize int CHECK(CabSize IS NOT NULL),
//    CA_Length nvarchar(255) CHECK(CA_Length IS NOT NULL),
//    CA_UnitSystem nvarchar(255) CHECK(CA_UnitSystem IS NOT NULL),
//    CA_Temperature nvarchar(255) CHECK(CA_Temperature IS NOT NULL),
//    CA_TemperatureCode nvarchar(255) CHECK(CA_TemperatureCode IS NOT NULL),
//    LengthValue nvarchar(255) CHECK(LengthValue IS NOT NULL),
//    CableLengthUnit nvarchar(255) CHECK(CableLengthUnit IS NOT NULL),
//    Tolerance nvarchar(255) CHECK(Tolerance IS NOT NULL),
//    MinTempValue int CHECK(MinTempValue IS NOT NULL),
//    MaxTempValue int CHECK(MaxTempValue IS NOT NULL),
//    RPosValue float CHECK(RPosValue IS NOT NULL),
//    XPosValue float CHECK(XPosValue IS NOT NULL),
//    YPosValue float CHECK(YPosValue IS NOT NULL),
//    RZeroValue float CHECK(RZeroValue IS NOT NULL),
//    XZeroValue float CHECK(XZeroValue IS NOT NULL),
//    YZeroValue float CHECK(YZeroValue IS NOT NULL),
//    ImpedanceUnits float CHECK(ImpedanceUnits IS NOT NULL),
//    OhmsPerLengthValue float CHECK(OhmsPerLengthValue IS NOT NULL),
//    OhmsPerLengthUnit float CHECK(OhmsPerLengthUnit IS NOT NULL),
//    CommentText nvarchar(255) CHECK(CommentText IS NOT NULL),
//    Created_Date datetime DEFAULT GETDATE() CHECK(Created_Date IS NOT NULL),
//    GroundWireSize int CHECK(GroundWireSize IS NOT NULL),
//    CableSize int CHECK(CableSize IS NOT NULL),
//    VoltageLevel nvarchar(255) CHECK(VoltageLevel IS NOT NULL),
//    CableVoltage nvarchar(255) CHECK(CableVoltage IS NOT NULL)
//);
