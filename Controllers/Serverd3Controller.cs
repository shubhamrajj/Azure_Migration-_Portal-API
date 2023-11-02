using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using ctrlspec.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ctrlspec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerD3Controller : ControllerBase
    {
        private readonly ApplicationService _applicationService;

        public ServerD3Controller(ApplicationService applicationService)

        {

            _applicationService = applicationService;

        }


        [HttpGet]
        public IActionResult GetServerList()
        {
            var serverListData =   _applicationService.GetServerLists()
                .Select(s => new ServerList
                {
                    Id = s.Id,
                    ServerId = s.ServerId,
                    ServerLabel = s.ServerLabel,
                    Global = s.Global,
                    ITLandscape = s.ITLandscape,
                    ScatterView = s.ScatterView,
                    Size = s.Size,
                    InProduction = s.InProduction,
                    Environment = s.Environment,
                    Virtualized = s.Virtualized,
                    TypeOfServer = s.TypeOfServer,
                    TypeOfServerNormalized = s.TypeOfServerNormalized,
                    Datacenter = s.Datacenter,
                    ServerDetailedLocation = s.ServerDetailedLocation,
                    Country = s.Country,
                    OS = s.OS,
                    OSNormalized = s.OSNormalized,
                    OSVersion = s.OSVersion,
                    OSVersionNormalized = s.OSVersionNormalized,
                    ReservedInstance = s.ReservedInstance,
                    Teeshirt = s.Teeshirt,
                    Region = s.Region,
                    ServerMigrationMonth = s.ServerMigrationMonth,
                    ServerTargetInfrastructure = s.ServerTargetInfrastructure,
                    ServerMigrationPath = s.ServerMigrationPath,
                    IsOrphan = s.IsOrphan,
                    IsMutualized = s.IsMutualized,
                    FixedSize = s.FixedSize,
                    NumberOfApplicationsMapped = s.NumberOfApplicationsMapped,
                    NumberOfCPU = s.NumberOfCPU,
                    RAMSize = s.RAMSize,
                    TotalAllocatedDiskSize = s.TotalAllocatedDiskSize,
                    UsedDiskSize = s.UsedDiskSize,
                    UsageHour = s.UsageHour,
                    CurrentCost = s.CurrentCost,
                    ServerMigrationCost = s.ServerMigrationCost,
                    AWSCostPerYear = s.AWSCostPerYear,
                    AzureCostPerYear = s.AzureCostPerYear,
                    SRVTCF = s.SRVTCF,
                    MANUF = s.MANUF,
                    RUN = s.RUN,
                    RUNMarketBased = s.RUNMarketBased,
                    Energy = s.Energy,
                    EnergyPUEIncluded = s.EnergyPUEIncluded,
                    WebCollectCompleteness = s.WebCollectCompleteness,
                    ServerOSObsolescence = s.ServerOSObsolescence,
                    SRVCarbonIntensityRate = s.SRVCarbonIntensityRate,
                    SRVRenewableEnergyRate = s.SRVRenewableEnergyRate,
                    SRVPUERate = s.SRVPUERate,
                    SRVHostingRate = s.SRVHostingRate,
                    SRVHostingRateRECIncluded = s.SRVHostingRateRECIncluded,
                    RowNumber = s.RowNumber
                })
                .ToList();

            return Ok(serverListData);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ServerList serverList)
        {
            if (serverList == null)
            {
                return BadRequest("Invalid data provided.");
            }

            // Perform any necessary validation or processing on the received data
            // For example, you might want to add it to the database using the ServerListService

            // _serverListService.AddServer(serverList);

            // Return a success message or the created serverList
            return Ok(serverList);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ServerList serverList)
        {
            if (serverList == null || serverList.Id != id)
            {
                return BadRequest("Invalid data provided.");
            }

            // Perform any necessary validation or processing on the received data
            // For example, you might want to update it in the database using the ServerListService

            // _serverListService.UpdateServer(serverList);

            // Return a success message or the updated serverList
            return Ok(serverList);
        }
[HttpGet("ApplicationAndServer")]
public IActionResult GetServerWithApplications()
{
    var applicationsWithServers = _applicationService.GetApplicationLists()
        .Select(app => new
        {
            app.AppId,
            app.ApplicationId,
            app.ApplicationLabel,
            ApplicationServer = GetServerDataForApplication(app.AppId)
        })
        .ToList();

    return Ok(applicationsWithServers);
}

private List<object> GetServerDataForApplication(int? appId)
{
    var serverDataForApplication = _applicationService.GetServerLists()
        .Where(server => server.AppId == appId)
        .Select(server => new
        {
            server.ServerId,
            server.ServerLabel
        })
        .ToList<object>();

    return serverDataForApplication;
}
public class ServerInfo
{
    public int? ServerId { get; set; }
    public required string ServerLabel { get; set; }
}
        // You can add other CRUD operations as needed
    }
}
