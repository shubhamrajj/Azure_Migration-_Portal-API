using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.Linq;

using System.Threading.Tasks;

using ctrlspec.Models;

using ctrlspec.Services;

using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;




namespace ctrlspec.Controllers

{

    // [Route("[controller]")]

    // public class ApplicationD3Controller : Controller

    // {

    //     private readonly ILogger<ApplicationD3Controller> _logger;




    //     public ApplicationD3Controller(ILogger<ApplicationD3Controller> logger)

    //     {

    //         _logger = logger;

    //     }




    //     public IActionResult Index()

    //     {

    //         return View();

    //     }




    //     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    //     public IActionResult Error()

    //     {

    //         return View("Error!");

    //     }

    // }




    [Route("api/[controller]")]

    [ApiController]

    public class ApplicationD3Controller : ControllerBase

    {

        private readonly ApplicationService _applicationService;




        public ApplicationD3Controller(ApplicationService applicationService)

        {

            _applicationService = applicationService;

        }




        // [HttpGet]

        // public ActionResult<IEnumerable<Application>> GetApplications()

        // {

        //     var applications = _applicationService.GetApplications();

        //     return Ok(applications);

        // }




    //      [HttpGet]

    // public IActionResult Get()

    // {

    //     var applicationData = _applicationService.GetApplications()

    //         .Select(a => new

    //         {

    //             ApplicationName = a.Application_Name,

    //             ServerName = a.Serverinfo,

    //             //PortInfo = a.Server.Ports.Select(p => p.PortNumber)

    //             PortInfo = a.Portinfo,

    //         })

    //         .ToList();

    //          return Ok(applicationData);

    // }

   //For ApplicationList 
 [HttpGet]   
        public IActionResult GetApp()
        {
            var applicationData = _applicationService.GetApplicationLists()
                .Select(a => new ApplicationList
                {
                    AppId = a.AppId,
                    ApplicationId = a.ApplicationId,
                    ApplicationLabel = a.ApplicationLabel,
                    Global = a.Global,
                    ITLandscape = a.ITLandscape,
                    ScatterView = a.ScatterView,
                    Size = a.Size,
                    ProjectPortfolio = a.ProjectPortfolio,
                    CreationYear = a.CreationYear,
                    DecommissioningPlan = a.DecommissioningPlan,
                    ITDomain = a.ITDomain,
                    ITSubDomain = a.ITSubDomain,
                    BusinessDomain = a.BusinessDomain,
                    BusinessProcessLevel1 = a.BusinessProcessLevel1,
                    BusinessProcessLevel2 = a.BusinessProcessLevel2,
                    MainTechnologies = a.MainTechnologies,
                    SolutionMix = a.SolutionMix,
                    PackageCategory = a.PackageCategory,
                    NumberOfUsers = a.NumberOfUsers,
                    ReadyForAssessment = a.ReadyForAssessment,
                    Scope = a.Scope,
                    NicheProgrammingLanguage = a.NicheProgrammingLanguage,
                    DecommissioningType = a.DecommissioningType,
                    Package = a.Package,
                    SMAC = a.SMAC,
                    Regulatory = a.Regulatory,
                    Deployment = a.Deployment,
                    IntDeliveryModel = a.IntDeliveryModel,
                    ExtDeliveryModel = a.ExtDeliveryModel,
                    DRP = a.DRP,
                    RedundantApplications = a.RedundantApplications,
                    DatabaseManagementSystem = a.DatabaseManagementSystem,
                    ApplicationServer = a.ApplicationServer,
                    TargetApplication = a.TargetApplication,
                    HostingMode = a.HostingMode,
                    CloudTargetInfrastructure = a.CloudTargetInfrastructure,
                    CloudMigrationPath = a.CloudMigrationPath,
                    CloudMigrationComplexity = a.CloudMigrationComplexity,
                    CloudServiceModel = a.CloudServiceModel,
                    Rationale = a.Rationale,
                    PublicCloudBlocker = a.PublicCloudBlocker,
                    CloudMigrationWave = a.CloudMigrationWave,
                    MainOSInProduction = a.MainOSInProduction,
                    MainOS = a.MainOS,
                    MainProdServersLocations = a.MainProdServersLocations,
                    RationalizationDestiny = a.RationalizationDestiny,
                    RationalizationCategory = a.RationalizationCategory,
                    RationalizationType = a.RationalizationType,
                    CandidateToGHOSTSRV = a.CandidateToGHOSTSRV,
                    CandidateToPSMutualization = a.CandidateToPSMutualization,
                    FixedSize = a.FixedSize,
                    TotalServers = a.TotalServers,
                    ProductionServers = a.ProductionServers,
                    ProductionVirtualServers = a.ProductionVirtualServers,
                    ProductionPhysicalServers = a.ProductionPhysicalServers,
                    NonProductionServers = a.NonProductionServers,
                    NonProductionVirtualServers = a.NonProductionVirtualServers,
                    AllocatedDiskSpace = a.AllocatedDiskSpace,
                    UsedDiskSpace = a.UsedDiskSpace,
                    FTE = a.FTE,
                    FTEInternal = a.FTEInternal,
                    FTEExternal = a.FTEExternal,
                    FTEExternalFP = a.FTEExternalFP,
                    FTEMajorChanges = a.FTEMajorChanges,
                    FTEMinorChanges = a.FTEMinorChanges,
                    FTEProblems = a.FTEProblems,
                    FTEServiceRequests = a.FTEServiceRequests,
                    TCO = a.TCO,
                    TotalStaffCost = a.TotalStaffCost,
                    InternalStaffCost = a.InternalStaffCost,
                    ExternalStaffCost = a.ExternalStaffCost,
                    TotalInfrastructureCost = a.TotalInfrastructureCost,
                    HardwareCost = a.HardwareCost,
                    LicenseCost = a.LicenseCost,
                    ManagedServicesCost = a.ManagedServicesCost,
                    ExternalFPStaffCost = a.ExternalFPStaffCost,
                    MajorChangesCost = a.MajorChangesCost,
                    MinorChangesCost = a.MinorChangesCost,
                    ProblemsCost = a.ProblemsCost,
                    ServiceRequestsCost = a.ServiceRequestsCost,
                    NumberOfMinorChanges = a.NumberOfMinorChanges,
                    NumberOfProblems = a.NumberOfProblems,
                    NumberOfServiceRequests = a.NumberOfServiceRequests,
                    BacklogMinorChanges = a.BacklogMinorChanges,
                    BacklogProblems = a.BacklogProblems,
                    BacklogServiceRequests = a.BacklogServiceRequests,
                    HAETProblems = a.HAETProblems,
                    NumberOfMajorReleases = a.NumberOfMajorReleases,
                    NumberOfITPPerYear = a.NumberOfITPPerYear,
                    CloudMigrationComplexitySize = a.CloudMigrationComplexitySize,
                    CostPerYearAWS = a.CostPerYearAWS,
                    CostPerYearAzure = a.CostPerYearAzure,
                    TCFKgCO2ePerYear = a.TCFKgCO2ePerYear,
                    COMPUTE = a.COMPUTE,
                    COMPUTEMANUF = a.COMPUTEMANUF,
                    COMPUTERUN = a.COMPUTERUN,
                    COMPUTERUNMarketBased = a.COMPUTERUNMarketBased,
                    OPERATINGMODEL = a.OPERATINGMODEL,
                    Criticality = a.Criticality,
                    Dynamism = a.Dynamism,
                    ServiceLevel = a.ServiceLevel,
                    FunctionalComplexity = a.FunctionalComplexity,
                    Usage = a.Usage,
                    BusinessDifferentiation = a.BusinessDifferentiation,
                    DemandQuality = a.DemandQuality,
                    BusinessNeedsAdequacy = a.BusinessNeedsAdequacy,
                    RequiredTTM = a.RequiredTTM,
                    DevOpsMaturity = a.DevOpsMaturity,
                    QOS = a.QOS,
                    MaxAcceptableDowntime = a.MaxAcceptableDowntime,
                    TechnicalObsolescence = a.TechnicalObsolescence,
                    CodeQuality = a.CodeQuality,
                    Maintainability = a.Maintainability,
                    SourceCodeAvailability = a.SourceCodeAvailability,
                    LevelOfIntegration = a.LevelOfIntegration,
                    PackageCustomization = a.PackageCustomization,
                    AgeOfApplication = a.AgeOfApplication,
                    SuppliersDependency = a.SuppliersDependency,
                    GlobalOffshoreRatio = a.GlobalOffshoreRatio,
                    InternalOffshoreRatio = a.InternalOffshoreRatio,
                    ExternalOffshoreRatio = a.ExternalOffshoreRatio,
                    ChangeIndex = a.ChangeIndex,
                    ITDigitalReadiness = a.ITDigitalReadiness,
                    WebCollectCompleteness = a.WebCollectCompleteness,
                    LevelOfRobustness = a.LevelOfRobustness,
                    OSObsolescence = a.OSObsolescence,
                    VirtualizationRate = a.VirtualizationRate,
                    DiskSpaceUsed = a.DiskSpaceUsed,
                    ProductionServerRate = a.ProductionServerRate,
                    GlobalRisk = a.GlobalRisk,
                    SecurityRisk = a.SecurityRisk,
                    InstabilityRisk = a.InstabilityRisk,
                    MaintainabilityRisk = a.MaintainabilityRisk,
                    TechnicalObsolescenceRisk = a.TechnicalObsolescenceRisk,
                    VolatilityRisk = a.VolatilityRisk,
                    PeopleDependencyRisk = a.PeopleDependencyRisk,
                    SuppliersDependencyRisk = a.SuppliersDependencyRisk,
                    LicensePortability = a.LicensePortability,
                    CloudCompatibleArchitecture = a.CloudCompatibleArchitecture,
                    DataResidency = a.DataResidency,
                    DataClassification = a.DataClassification,
                    VirtualizationStatus = a.VirtualizationStatus,
                    RTO = a.RTO,
                    RPO = a.RPO,
                    ResponseTimeLatencyRequirement = a.ResponseTimeLatencyRequirement,
                    Security = a.Security,
                    SecurityCompliance = a.SecurityCompliance,
                    Availability = a.Availability,
                    Integrity = a.Integrity,
                    Confidentiality = a.Confidentiality,
                    Proof = a.Proof,
                    RationalizationSolutionQuality = a.RationalizationSolutionQuality,
                    RationalizationTCOLevel = a.RationalizationTCOLevel,
                    CyberSecurityScore = a.CyberSecurityScore,
                    CarbonIntensityRate = a.CarbonIntensityRate,
                    PUERate = a.PUERate,
                    RenewableEnergyRate = a.RenewableEnergyRate,
                    HostingRate = a.HostingRate,
                    HostingRateRECIncluded = a.HostingRateRECIncluded,
                    ManufacturingRate = a.ManufacturingRate,
                    CloudRate = a.CloudRate,
                    // Add other properties as needed
                })
                .ToList();

            return Ok(applicationData);
        }

        // POST: api/ApplicationList
        [HttpPost]
        public IActionResult Post([FromBody] ApplicationList applicationList)
        {
            if (applicationList == null)
            {
                return BadRequest("Invalid data provided.");
            }

            // Perform any necessary validation or processing on the received data
            // For example, you might want to add it to the database using the ApplicationService

            // _applicationService.AddApplication(applicationList);

            // Return a success message or the created applicationList
            return Ok(applicationList);
        }

        // PUT: api/ApplicationList/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ApplicationList applicationList)
        {
            if (applicationList == null || applicationList.AppId != id)
            {
                return BadRequest("Invalid data provided.");
            }

            // Perform any necessary validation or processing on the received data
            // For example, you might want to update it in the database using the ApplicationService

            // _applicationService.UpdateApplication(applicationList);

            // Return a success message or the updated applicationList
            return Ok(applicationList);
        }


    }

}