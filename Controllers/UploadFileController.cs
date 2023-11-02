using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

using ctrlspec.Models;
using ctrlspec.Data;

namespace ctrlspec.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadFileController : ControllerBase
    {
        private readonly CtrlSpecDbContext _dbContext;

        public UploadFileController(CtrlSpecDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Please select a file to upload.");
            }

            using (var package = new ExcelPackage(file.OpenReadStream()))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension.Rows;

                List<ApplicationList> applications = new List<ApplicationList>();
                for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
                {

                    applications.Add(new ApplicationList
                    {
                        ApplicationId = worksheet.Cells[row, 1].Value?.ToString(),
                        ApplicationLabel = worksheet.Cells[row, 2].Value?.ToString(),
                        Global = worksheet.Cells[row, 3].Value?.ToString(),
                        ITLandscape = worksheet.Cells[row, 4].Value?.ToString(),
                        ScatterView = worksheet.Cells[row, 5].Value?.ToString(),
                        Size = worksheet.Cells[row, 6].Value?.ToString(),
                        ProjectPortfolio = worksheet.Cells[row, 7].Value?.ToString(),
                        CreationYear = worksheet.Cells[row, 8].Value?.ToString(),
                        DecommissioningPlan = worksheet.Cells[row, 9].Value?.ToString(),
                        ITDomain = worksheet.Cells[row, 10].Value?.ToString(),
                        ITSubDomain = worksheet.Cells[row, 11].Value?.ToString(),
                        BusinessDomain = worksheet.Cells[row, 12].Value?.ToString(),
                        BusinessProcessLevel1 = worksheet.Cells[row, 13].Value?.ToString(),
                        BusinessProcessLevel2 = worksheet.Cells[row, 14].Value?.ToString(),
                        MainTechnologies = worksheet.Cells[row, 15].Value?.ToString(),
                        SolutionMix = worksheet.Cells[row, 16].Value?.ToString(),
                        PackageCategory = worksheet.Cells[row, 17].Value?.ToString(),
                        NumberOfUsers = worksheet.Cells[row, 18].Value?.ToString(),
                        ReadyForAssessment = worksheet.Cells[row, 19].Value?.ToString(),
                        Scope = worksheet.Cells[row, 20].Value?.ToString(),
                        NicheProgrammingLanguage = worksheet.Cells[row, 21].Value?.ToString(),
                        DecommissioningType = worksheet.Cells[row, 22].Value?.ToString(),
                        Package = worksheet.Cells[row, 23].Value?.ToString(),
                        SMAC = worksheet.Cells[row, 24].Value?.ToString(),
                        Regulatory = worksheet.Cells[row, 25].Value?.ToString(),
                        Deployment = worksheet.Cells[row, 26].Value?.ToString(),
                        IntDeliveryModel = worksheet.Cells[row, 27].Value?.ToString(),
                        ExtDeliveryModel = worksheet.Cells[row, 28].Value?.ToString(),
                        DRP = worksheet.Cells[row, 29].Value?.ToString(),
                        RedundantApplications = worksheet.Cells[row, 30].Value?.ToString(),
                        DatabaseManagementSystem = worksheet.Cells[row, 31].Value?.ToString(),
                        ApplicationServer = worksheet.Cells[row, 32].Value?.ToString(),
                        TargetApplication = worksheet.Cells[row, 33].Value?.ToString(),
                        HostingMode = worksheet.Cells[row, 34].Value?.ToString(),
                        CloudTargetInfrastructure = worksheet.Cells[row, 35].Value?.ToString(),
                        CloudMigrationPath = worksheet.Cells[row, 36].Value?.ToString(),
                        CloudMigrationComplexity = worksheet.Cells[row, 37].Value?.ToString(),
                        CloudServiceModel = worksheet.Cells[row, 38].Value?.ToString(),
                        Rationale = worksheet.Cells[row, 39].Value?.ToString(),
                        PublicCloudBlocker = worksheet.Cells[row, 40].Value?.ToString(),
                        CloudMigrationWave = worksheet.Cells[row, 41].Value?.ToString(),
                        MainOSInProduction = worksheet.Cells[row, 42].Value?.ToString(),
                        MainOS = worksheet.Cells[row, 43].Value?.ToString(),
                        MainProdServersLocations = worksheet.Cells[row, 44].Value?.ToString(),
                        RationalizationDestiny = worksheet.Cells[row, 45].Value?.ToString(),
                        RationalizationCategory = worksheet.Cells[row, 46].Value?.ToString(),
                        RationalizationType = worksheet.Cells[row, 47].Value?.ToString(),
                        CandidateToGHOSTSRV = worksheet.Cells[row, 48].Value?.ToString(),
                        CandidateToPSMutualization = worksheet.Cells[row, 49].Value?.ToString(),
                        FixedSize = worksheet.Cells[row, 50].Value?.ToString(),
                        TotalServers = worksheet.Cells[row, 51].Value?.ToString(),
                        ProductionServers = worksheet.Cells[row, 52].Value?.ToString(),
                        ProductionVirtualServers = worksheet.Cells[row, 53].Value?.ToString(),
                        ProductionPhysicalServers = worksheet.Cells[row, 54].Value?.ToString(),
                        NonProductionServers = worksheet.Cells[row, 55].Value?.ToString(),
                        NonProductionVirtualServers = worksheet.Cells[row, 56].Value?.ToString(),
                        AllocatedDiskSpace = worksheet.Cells[row, 57].Value?.ToString(),
                        UsedDiskSpace = worksheet.Cells[row, 58].Value?.ToString(),
                        FTE = worksheet.Cells[row, 59].Value?.ToString(),
                        FTEInternal = worksheet.Cells[row, 60].Value?.ToString(),
                        FTEExternal = worksheet.Cells[row, 61].Value?.ToString(),
                        FTEExternalFP = worksheet.Cells[row, 62].Value?.ToString(),
                        FTEMajorChanges = worksheet.Cells[row, 63].Value?.ToString(),
                        FTEMinorChanges = worksheet.Cells[row, 64].Value?.ToString(),
                        FTEProblems = worksheet.Cells[row, 65].Value?.ToString(),
                        FTEServiceRequests = worksheet.Cells[row, 66].Value?.ToString(),
                        TCO = worksheet.Cells[row, 67].Value?.ToString(),
                        TotalStaffCost = worksheet.Cells[row, 68].Value?.ToString(),
                        InternalStaffCost = worksheet.Cells[row, 69].Value?.ToString(),
                        ExternalStaffCost = worksheet.Cells[row, 70].Value?.ToString(),
                        TotalInfrastructureCost = worksheet.Cells[row, 71].Value?.ToString(),
                        HardwareCost = worksheet.Cells[row, 72].Value?.ToString(),
                        LicenseCost = worksheet.Cells[row, 73].Value?.ToString(),
                        ManagedServicesCost = worksheet.Cells[row, 74].Value?.ToString(),
                        ExternalFPStaffCost = worksheet.Cells[row, 75].Value?.ToString(),
                        MajorChangesCost = worksheet.Cells[row, 76].Value?.ToString(),
                        MinorChangesCost = worksheet.Cells[row, 77].Value?.ToString(),
                        ProblemsCost = worksheet.Cells[row, 78].Value?.ToString(),
                        ServiceRequestsCost = worksheet.Cells[row, 79].Value?.ToString(),
                        NumberOfMinorChanges = worksheet.Cells[row, 80].Value?.ToString(),
                        NumberOfProblems = worksheet.Cells[row, 81].Value?.ToString(),
                        NumberOfServiceRequests = worksheet.Cells[row, 82].Value?.ToString(),
                        BacklogMinorChanges = worksheet.Cells[row, 83].Value?.ToString(),
                        BacklogProblems = worksheet.Cells[row, 84].Value?.ToString(),
                        BacklogServiceRequests = worksheet.Cells[row, 85].Value?.ToString(),
                        HAETProblems = worksheet.Cells[row, 86].Value?.ToString(),
                        NumberOfMajorReleases = worksheet.Cells[row, 87].Value?.ToString(),
                        NumberOfITPPerYear = worksheet.Cells[row, 88].Value?.ToString(),
                        CloudMigrationComplexitySize = worksheet.Cells[row, 89].Value?.ToString(),
                        CostPerYearAWS = worksheet.Cells[row, 90].Value?.ToString(),
                        CostPerYearAzure = worksheet.Cells[row, 91].Value?.ToString(),
                        TCFKgCO2ePerYear = worksheet.Cells[row, 92].Value?.ToString(),
                        COMPUTE = worksheet.Cells[row, 93].Value?.ToString(),
                        COMPUTEMANUF = worksheet.Cells[row, 94].Value?.ToString(),
                        COMPUTERUN = worksheet.Cells[row, 95].Value?.ToString(),
                        COMPUTERUNMarketBased = worksheet.Cells[row, 96].Value?.ToString(),
                        OPERATINGMODEL = worksheet.Cells[row, 97].Value?.ToString(),
                        Criticality = worksheet.Cells[row, 98].Value?.ToString(),
                        Dynamism = worksheet.Cells[row, 99].Value?.ToString(),
                        ServiceLevel = worksheet.Cells[row, 100].Value?.ToString(),
                        FunctionalComplexity = worksheet.Cells[row, 101].Value?.ToString(),
                        Usage = worksheet.Cells[row, 102].Value?.ToString(),
                        BusinessDifferentiation = worksheet.Cells[row, 103].Value?.ToString(),
                        DemandQuality = worksheet.Cells[row, 104].Value?.ToString(),
                        BusinessNeedsAdequacy = worksheet.Cells[row, 105].Value?.ToString(),
                        RequiredTTM = worksheet.Cells[row, 106].Value?.ToString(),
                        DevOpsMaturity = worksheet.Cells[row, 107].Value?.ToString(),
                        QOS = worksheet.Cells[row, 108].Value?.ToString(),
                        MaxAcceptableDowntime = worksheet.Cells[row, 109].Value?.ToString(),
                        TechnicalObsolescence = worksheet.Cells[row, 110].Value?.ToString(),
                        CodeQuality = worksheet.Cells[row, 111].Value?.ToString(),
                        Maintainability = worksheet.Cells[row, 112].Value?.ToString(),
                        SourceCodeAvailability = worksheet.Cells[row, 113].Value?.ToString(),
                        LevelOfIntegration = worksheet.Cells[row, 114].Value?.ToString(),
                        PackageCustomization = worksheet.Cells[row, 115].Value?.ToString(),
                        AgeOfApplication = worksheet.Cells[row, 116].Value?.ToString(),
                        SuppliersDependency = worksheet.Cells[row, 117].Value?.ToString(),
                        GlobalOffshoreRatio = worksheet.Cells[row, 118].Value?.ToString(),
                        InternalOffshoreRatio = worksheet.Cells[row, 119].Value?.ToString(),
                        ExternalOffshoreRatio = worksheet.Cells[row, 120].Value?.ToString(),
                        ChangeIndex = worksheet.Cells[row, 121].Value?.ToString(),
                        ITDigitalReadiness = worksheet.Cells[row, 122].Value?.ToString(),
                        WebCollectCompleteness = worksheet.Cells[row, 123].Value?.ToString(),
                        LevelOfRobustness = worksheet.Cells[row, 124].Value?.ToString(),
                        OSObsolescence = worksheet.Cells[row, 125].Value?.ToString(),
                        VirtualizationRate = worksheet.Cells[row, 126].Value?.ToString(),
                        DiskSpaceUsed = worksheet.Cells[row, 127].Value?.ToString(),
                        ProductionServerRate = worksheet.Cells[row, 128].Value?.ToString(),
                        GlobalRisk = worksheet.Cells[row, 129].Value?.ToString(),
                        SecurityRisk = worksheet.Cells[row, 130].Value?.ToString(),
                        InstabilityRisk = worksheet.Cells[row, 131].Value?.ToString(),
                        MaintainabilityRisk = worksheet.Cells[row, 132].Value?.ToString(),
                        TechnicalObsolescenceRisk = worksheet.Cells[row, 133].Value?.ToString(),
                        VolatilityRisk = worksheet.Cells[row, 134].Value?.ToString(),
                        PeopleDependencyRisk = worksheet.Cells[row, 135].Value?.ToString(),
                        SuppliersDependencyRisk = worksheet.Cells[row, 136].Value?.ToString(),
                        LicensePortability = worksheet.Cells[row, 137].Value?.ToString(),
                        CloudCompatibleArchitecture = worksheet.Cells[row, 138].Value?.ToString(),
                        DataResidency = worksheet.Cells[row, 139].Value?.ToString(),
                        DataClassification = worksheet.Cells[row, 140].Value?.ToString(),
                        VirtualizationStatus = worksheet.Cells[row, 141].Value?.ToString(),
                        RTO = worksheet.Cells[row, 142].Value?.ToString(),
                        RPO = worksheet.Cells[row, 143].Value?.ToString(),
                        ResponseTimeLatencyRequirement = worksheet.Cells[row, 144].Value?.ToString(),
                        Security = worksheet.Cells[row, 145].Value?.ToString(),
                        SecurityCompliance = worksheet.Cells[row, 146].Value?.ToString(),
                        Availability = worksheet.Cells[row, 147].Value?.ToString(),
                        Integrity = worksheet.Cells[row, 148].Value?.ToString(),
                        Confidentiality = worksheet.Cells[row, 149].Value?.ToString(),
                        Proof = worksheet.Cells[row, 150].Value?.ToString(),
                        RationalizationSolutionQuality = worksheet.Cells[row, 151].Value?.ToString(),
                        RationalizationTCOLevel = worksheet.Cells[row, 152].Value?.ToString(),
                        CyberSecurityScore = worksheet.Cells[row, 153].Value?.ToString(),
                        CarbonIntensityRate = worksheet.Cells[row, 154].Value?.ToString(),
                        PUERate = worksheet.Cells[row, 155].Value?.ToString(),
                        RenewableEnergyRate = worksheet.Cells[row, 156].Value?.ToString(),
                        HostingRate = worksheet.Cells[row, 157].Value?.ToString(),
                        HostingRateRECIncluded = worksheet.Cells[row, 158].Value?.ToString(),
                        ManufacturingRate = worksheet.Cells[row, 159].Value?.ToString(),
                        CloudRate = worksheet.Cells[row, 160].Value?.ToString(),
                    
                        RowNumber = row // Set the RowNumber property to the current row index
                        
                    });
                }
                

                // Store data into the database
                 _dbContext.ApplicationLists.AddRange(applications.OrderBy(a => a.RowNumber));
                await _dbContext.SaveChangesAsync();

                return Ok("success");
            }

        }

        [HttpPost("Serverlist")]
        

        public async Task<IActionResult> UploadServerExcel(IFormFile file, int? appId)

        {

            if (file == null || file.Length == 0)

            {

                return BadRequest("Please select a file to upload.");

            }



           
            using (var package = new ExcelPackage(file.OpenReadStream()))

            {

                var worksheet = package.Workbook.Worksheets[0];

                var rowCount = worksheet.Dimension.Rows;




                List<ServerList> servers = new List<ServerList>();

                for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers

                {

                    servers.Add(new ServerList

                    {

                        ServerId = worksheet.Cells[row, 1].Value?.ToString(),

                        // AppId = worksheet.Cells[row, 2].Value?.ToString(),

                        ServerLabel = worksheet.Cells[row, 2].Value?.ToString(),

                        Global = worksheet.Cells[row, 3].Value?.ToString(),

                        ITLandscape = worksheet.Cells[row, 4].Value?.ToString(),

                        ScatterView = worksheet.Cells[row, 5].Value?.ToString(),

                        Size = worksheet.Cells[row, 6].Value?.ToString(),

                        InProduction = worksheet.Cells[row, 7].Value?.ToString(),

                        Environment = worksheet.Cells[row, 8].Value?.ToString(),

                        Virtualized = worksheet.Cells[row, 9].Value?.ToString(),

                        TypeOfServer = worksheet.Cells[row, 10].Value?.ToString(),

                        TypeOfServerNormalized = worksheet.Cells[row, 11].Value?.ToString(),

                        Datacenter = worksheet.Cells[row, 12].Value?.ToString(),

                        ServerDetailedLocation = worksheet.Cells[row, 13].Value?.ToString(),

                        Country = worksheet.Cells[row, 14].Value?.ToString(),

                        OS = worksheet.Cells[row, 15].Value?.ToString(),

                        OSNormalized = worksheet.Cells[row, 16].Value?.ToString(),

                        OSVersion = worksheet.Cells[row, 17].Value?.ToString(),

                        OSVersionNormalized = worksheet.Cells[row, 18].Value?.ToString(),

                        ReservedInstance = worksheet.Cells[row, 19].Value?.ToString(),

                        Teeshirt = worksheet.Cells[row, 20].Value?.ToString(),

                        Region = worksheet.Cells[row, 21].Value?.ToString(),

                        ServerMigrationMonth = worksheet.Cells[row, 22].Value?.ToString(),

                        ServerTargetInfrastructure = worksheet.Cells[row, 23].Value?.ToString(),

                        ServerMigrationPath = worksheet.Cells[row, 24].Value?.ToString(),

                        IsOrphan = worksheet.Cells[row, 25].Value?.ToString(),

                        IsMutualized = worksheet.Cells[row, 26].Value?.ToString(),

                        FixedSize = worksheet.Cells[row, 27].Value?.ToString(),

                        NumberOfApplicationsMapped = worksheet.Cells[row, 28].Value?.ToString(),

                        NumberOfCPU = worksheet.Cells[row, 29].Value?.ToString(),

                        RAMSize = worksheet.Cells[row, 30].Value?.ToString(),

                        TotalAllocatedDiskSize = worksheet.Cells[row, 31].Value?.ToString(),

                        UsedDiskSize = worksheet.Cells[row, 32].Value?.ToString(),

                        UsageHour = worksheet.Cells[row, 33].Value?.ToString(),

                        CurrentCost = worksheet.Cells[row, 34].Value?.ToString(),

                        ServerMigrationCost = worksheet.Cells[row, 35].Value?.ToString(),

                        AWSCostPerYear = worksheet.Cells[row, 36].Value?.ToString(),

                        AzureCostPerYear = worksheet.Cells[row, 37].Value?.ToString(),

                        SRVTCF = worksheet.Cells[row, 38].Value?.ToString(),

                        MANUF = worksheet.Cells[row, 39].Value?.ToString(),

                        RUN = worksheet.Cells[row, 40].Value?.ToString(),

                        RUNMarketBased = worksheet.Cells[row, 41].Value?.ToString(),

                        Energy = worksheet.Cells[row, 42].Value?.ToString(),

                        EnergyPUEIncluded = worksheet.Cells[row, 43].Value?.ToString(),

                        WebCollectCompleteness = worksheet.Cells[row, 44].Value?.ToString(),

                        ServerOSObsolescence = worksheet.Cells[row, 45].Value?.ToString(),

                        SRVCarbonIntensityRate = worksheet.Cells[row, 46].Value?.ToString(),

                        SRVRenewableEnergyRate = worksheet.Cells[row, 47].Value?.ToString(),

                        SRVPUERate = worksheet.Cells[row, 48].Value?.ToString(),

                        SRVHostingRate = worksheet.Cells[row, 49].Value?.ToString(),

                        SRVHostingRateRECIncluded = worksheet.Cells[row, 50].Value?.ToString(),
                        AppId = appId + 1,
                          RowNumber = row // Set the RowNumber property to the current row index

                    });
                    appId ++;

                }




                // Store data into the database

                 _dbContext.ServerLists.AddRange(servers);

                 _dbContext.SaveChanges();
                  return Ok("success");
            }

        }

    }
}
