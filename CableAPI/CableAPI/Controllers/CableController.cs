using CableAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
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

            var sql = @"
            SELECT ID, OtiGUID, FromBus, ToBus, Created_Date   
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
        public IActionResult CreateCable(Cable cable)
        {
            Cable data = new Cable
            {
                ID = cable.ID,
                OtiGUID = cable.OtiGUID,
                PhaseValue = cable.PhaseValue,
                InService = cable.InService,
                InServiceState = cable.InServiceState,
                Description = cable.Description,
                Phase = cable.Phase,
                NumberOfWires = cable.NumberOfWires,
                FromBus = cable.FromBus,
                ToBus = cable.ToBus,
                Frequency = cable.Frequency,
                CA_ConductorType = cable.CA_ConductorType,
                CA_Installation = cable.CA_Installation,
                CA_RatedkV = cable.CA_RatedkV,
                CA_PercentClass = cable.CA_PercentClass,
                CA_Source = cable.CA_Source,
                CA_Insulation = cable.CA_Insulation,
                CA_NoofConductors = cable.CA_NoofConductors,
                CabSize = cable.CabSize,
                CableSize = cable.CableSize,
                CA_Length = cable.CA_Length,
                CA_UnitSystem = cable.CA_UnitSystem,
                CA_Temperature = cable.CA_Temperature,
                CA_TemperatureCode = cable.CA_TemperatureCode,
                LengthValue = cable.LengthValue,
                CableLengthUnit = cable.CableLengthUnit,
                Tolerance = cable.Tolerance,
                MinTempValue = cable.MinTempValue,
                MaxTempValue = cable.MaxTempValue,
                RPosValue = cable.RPosValue,
                XPosValue = cable.XPosValue,
                YPosValue = cable.YPosValue,
                RZeroValue = cable.RZeroValue,
                XZeroValue = cable.XZeroValue,
                YZeroValue = cable.YZeroValue,
                ImpedanceUnits = cable.ImpedanceUnits,
                OhmsPerLengthValue = cable.OhmsPerLengthValue,
                OhmsPerLengthUnit = cable.OhmsPerLengthUnit,
                GroundWireSize = cable.GroundWireSize,
                CommentText = cable.CommentText,
                CableVoltage = cable.CableVoltage,
                VoltageLevel = cable.VoltageLevel,
                WireConnection = cable.WireConnection,
                CableNumber = cable.CableNumber,
                LoadValue = cable.LoadValue,
                LibraryLengthUnit = cable.LibraryLengthUnit,
                LibraryLength = cable.LibraryLength,
                State = cable.State
            };
            if (cable.Created_Date != null) data.Created_Date = cable.Created_Date;

            var sql = @"INSERT INTO dbo.Cable
                          VALUES (
                              @ID, @OtiGUID, @PhaseValue, @InService, @InServiceState, 
                              @Description, @Phase, @NumberOfWires, @FromBus, @ToBus, 
                              @Frequency, @CA_ConductorType, @CA_Installation, @CA_RatedkV, 
                              @CA_PercentClass, @CA_Source, @CA_Insulation, @CA_NoofConductors, 
                              @CabSize, @CA_Length, @CA_UnitSystem, @CA_Temperature, 
                              @CA_TemperatureCode, @LengthValue, @CableLengthUnit, @Tolerance, 
                              @MinTempValue, @MaxTempValue, @RPosValue, @XPosValue, @YPosValue, 
                              @RZeroValue, @XZeroValue, @YZeroValue, @ImpedanceUnits, 
                              @OhmsPerLengthValue, @OhmsPerLengthUnit, @CommentText, 
                              @CableVoltage, @Created_Date, @CableNumber, @LoadValue, 
                              @LibraryLengthUnit, @LibraryLength, @State, @GroundWireSize, 
                              @CableSize, @VoltageLevel, @WireConnection
                          )";

            try
            {
                SqlDataAccess.SaveData(sql, data);
                return Ok("Cable created Successfully");
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occured while creating the cable: " + ex.Message);
            }

        }

        [HttpGet("/DeleteCable")]
        public IActionResult DeleteCable(string ID)
        {
            string connectionString = SqlDataAccess.GetConnectionString();
            string sql = @"DELETE FROM dbo.Cable WHERE ID = @ID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return Ok("Record deleted successfully");
                    }
                    else
                    {
                        return NotFound("Record not found");
                    }
                }
            }
        }
    }
}
