using CableAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CableAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CableController : ControllerBase
    {
        private readonly ILogger<CableController> _logger;

        public CableController(ILogger<CableController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/GetCables")]
        public IEnumerable<BaseCable> GetCables()
        {
            var sql = @"SELECT TOP 10 ID, OtiGUID, FromBus, ToBus   
            FROM dbo.Cable;";
            return SqlDataAccess.LoadData<BaseCable>(sql, null);
        }

        [HttpGet("/GetCable/{ID}")]
        public IActionResult GetCable(string ID)
        {
            try
            {
                var cable = SqlDataAccess.LoadData<Cable>(null, ID).FirstOrDefault();

                if (cable == null)
                {
                    return NotFound("Cable not found");
                }

                return Ok(cable);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request: " + ex);
            }
        }


        [HttpPost("/CreateCable")]
        public IActionResult CreateCable(
            string id, string otiGuid, string phaseValue, bool inService, string inServiceState,
            string description, string phase, int numberOfWires, string fromBus,
            string toBus, int frequency, string caConductorType, string caInstallation,
            string caRatedkV, string caPercentClass, string caSource, string caInsulation,
            string caNoofConductors, int cabSize, string caLength, string caUnitSystem,
            string caTemperature, string caTemperatureCode, string lengthValue,
            string cableLengthUnit, string tolerance, int minTempValue, int maxTempValue,
            double rPosValue, double xPosValue, double yPosValue, double rZeroValue,
            double xZeroValue, double yZeroValue, double impedanceUnits,
            double ohmsPerLengthValue, double ohmsPerLengthUnit, string commentText)
        { 
            Cable data = new Cable{
                ID = id,
                OtiGUID = otiGuid,
                PhaseValue = phaseValue, 
                InService = inService, 
                InServiceState = inServiceState, 
                Description = description, 
                Phase = phase, 
                NumberOfWires = numberOfWires,
                FromBus = fromBus, 
                ToBus = toBus,
                Frequency = frequency, 
                CA_ConductorType = caConductorType, 
                CA_Installation = caInstallation, 
                CA_RatedkV = caRatedkV, 
                CA_PercentClass = caPercentClass,
                CA_Source = caSource, 
                CA_Insulation = caInsulation,
                CA_NoofConductors = caNoofConductors, 
                CabSize = cabSize,
                CA_Length = caLength, 
                CA_UnitSystem = caUnitSystem,
                CA_Temperature = caTemperature, 
                CA_TemperatureCode = caTemperatureCode, 
                LengthValue = lengthValue, 
                CableLengthUnit = cableLengthUnit,
                Tolerance = tolerance, 
                MinTempValue = minTempValue, 
                MaxTempValue = maxTempValue, 
                RPosValue = rPosValue, 
                XPosValue = xPosValue, 
                YPosValue = yPosValue, 
                RZeroValue = rZeroValue, 
                XZeroValue = xZeroValue, 
                YZeroValue = yZeroValue,
                ImpedanceUnits = impedanceUnits, 
                OhmsPerLengthValue = ohmsPerLengthValue, 
                OhmsPerLengthUnit = ohmsPerLengthUnit, 
                CommentText = commentText}
            ;
            var sql = @"INSERT INTO dbo.Cable 
            (ID, OtiGUID, PhaseValue, InService, InServiceState, Description, Phase, NumberOfWires, 
            FromBus, ToBus, Frequency, CA_ConductorType, CA_Installation, CA_RatedkV, 
            CA_PercentClass, CA_Source, CA_Insulation, CA_NoofConductors, CabSize, 
            CA_Length, CA_UnitSystem, CA_Temperature, CA_TemperatureCode, LengthValue, 
            CableLengthUnit, Tolerance, MinTempValue, MaxTempValue, RPosValue, XPosValue, 
            YPosValue, RZeroValue, XZeroValue, YZeroValue, ImpedanceUnits, 
            OhmsPerLengthValue, OhmsPerLengthUnit, CommentText) 
            VALUES 
            (@ID, @OtiGUID, @PhaseValue, @InService, @InServiceState, @Description, @Phase, @NumberOfWires, 
            @FromBus, @ToBus, @Frequency, @CA_ConductorType, @CA_Installation, @CA_RatedkV, 
            @CA_PercentClass, @CA_Source, @CA_Insulation, @CA_NoofConductors, @CabSize, 
            @CA_Length, @CA_UnitSystem, @CA_Temperature, @CA_TemperatureCode, @LengthValue, 
            @CableLengthUnit, @Tolerance, @MinTempValue, @MaxTempValue, @RPosValue, @XPosValue, 
            @YPosValue, @RZeroValue, @XZeroValue, @YZeroValue, @ImpedanceUnits, 
            @OhmsPerLengthValue, @OhmsPerLengthUnit, @CommentText);";

            SqlDataAccess.SaveData(sql, data);
            return Ok(); 
            
        }

        [HttpPut("/UpdateCable/{id}")]
        public IActionResult UpdateCable(string ID, [FromBody] Cable updatedCable)
        {
                var sql = @"UPDATE dbo.Cable 
                    SET PhaseValue = @PhaseValue, 
                    InService = @InService, 
                    InServiceState = @InServiceState, 
                    Description = @Description, 
                    Phase = @Phase, 
                    NumberOfWires = @NumberOfWires,
                    FromBus = @FromBus, 
                    ToBus = @ToBus, 
                    Frequency = @Frequency, 
                    CA_ConductorType = @CA_ConductorType, 
                    CA_Installation = @CA_Installation, 
                    CA_RatedkV = @CA_RatedkV, 
                    CA_PercentClass = @CA_PercentClass, 
                    CA_Source = @CA_Source, 
                    CA_Insulation = @CA_Insulation, 
                    CA_NoofConductors = @CA_NoofConductors, 
                    CabSize = @CabSize, 
                    CA_Length = @CA_Length, 
                    CA_UnitSystem = @CA_UnitSystem, 
                    CA_Temperature = @CA_Temperature, 
                    CA_TemperatureCode = @CA_TemperatureCode, 
                    LengthValue = @LengthValue, 
                    CableLengthUnit = @CableLengthUnit, 
                    Tolerance = @Tolerance, 
                    MinTempValue = @MinTempValue, 
                    MaxTempValue = @MaxTempValue,
                    RPosValue = @RPosValue, 
                    XPosValue = @XPosValue, 
                    YPosValue = @YPosValue, 
                    RZeroValue = @RZeroValue,
                    XZeroValue = @XZeroValue, 
                    YZeroValue = @YZeroValue, 
                    ImpedanceUnits = @ImpedanceUnits, 
                    OhmsPerLengthValue = @OhmsPerLengthValue, 
                    OhmsPerLengthUnit = @OhmsPerLengthUnit, 
                    CommentText = @CommentText 
                    WHERE ID = @ID;";
                SqlDataAccess.SaveData(sql, new 
                { 
                    ID = updatedCable.ID,
                    OtiGUID = updatedCable.OtiGUID,
                    PhaseValue = updatedCable.PhaseValue,
                    InService = updatedCable.InService,
                    InServiceState = updatedCable.InServiceState,
                    Description = updatedCable.Description,
                    Phase = updatedCable.Phase,
                    NumberOfWires = updatedCable.NumberOfWires,
                    FromBus = updatedCable.FromBus,
                    ToBus = updatedCable.ToBus,
                    Frequency = updatedCable.Frequency,
                    CA_ConductorType = updatedCable.CA_ConductorType,
                    CA_Installation = updatedCable.CA_Installation,
                    CA_RatedkV = updatedCable.CA_RatedkV,
                    CA_PercentClass = updatedCable.CA_PercentClass,
                    CA_Source = updatedCable.CA_Source,
                    CA_Insulation = updatedCable.CA_Insulation,
                    CA_NoofConductors = updatedCable.CA_NoofConductors,
                    CabSize = updatedCable.CabSize,
                    CA_Length = updatedCable.CA_Length,
                    CA_UnitSystem = updatedCable.CA_UnitSystem,
                    CA_Temperature = updatedCable.CA_Temperature,
                    CA_TemperatureCode = updatedCable.CA_TemperatureCode,
                    LengthValue = updatedCable.LengthValue,
                    CableLengthUnit = updatedCable.CableLengthUnit,
                    Tolerance = updatedCable.Tolerance,
                    MinTempValue = updatedCable.MinTempValue,
                    MaxTempValue = updatedCable.MaxTempValue,
                    RPosValue = updatedCable.RPosValue,
                    XPosValue = updatedCable.XPosValue,
                    YPosValue = updatedCable.YPosValue,
                    RZeroValue = updatedCable.RZeroValue,
                    XZeroValue = updatedCable.XZeroValue,
                    YZeroValue = updatedCable.YZeroValue,
                    ImpedanceUnits = updatedCable.ImpedanceUnits,
                    OhmsPerLengthValue = updatedCable.OhmsPerLengthValue,
                    OhmsPerLengthUnit = updatedCable.OhmsPerLengthUnit,
                    CommentText = updatedCable.CommentText,
                });

            return Ok("Update Successful");
        }

        [HttpDelete("/DeleteCable/{id}")]
        public IActionResult DeleteCable(string id)
        {
            string sql = @"DELETE FROM dbo.Cable WHERE ID = @ID;";
            int rowsAffected = SqlDataAccess.SaveData(sql, new { ID = id });

            if (rowsAffected > 0)
            {
                return Ok($"Cable with ID: {id} was deleted successfully.");
            }
            else
            {
                return NotFound("Cable with the specified ID was not found.");
            }
        }
    }
}

