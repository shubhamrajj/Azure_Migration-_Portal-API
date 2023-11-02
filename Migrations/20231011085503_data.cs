using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ctrlspec.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationLists",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Global = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITLandscape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScatterView = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPortfolio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecommissioningPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITSubDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessDomain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessProcessLevel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessProcessLevel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionMix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReadyForAssessment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NicheProgrammingLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecommissioningType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Package = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SMAC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regulatory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deployment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntDeliveryModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtDeliveryModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DRP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedundantApplications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatabaseManagementSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetApplication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostingMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudTargetInfrastructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudMigrationPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudMigrationComplexity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudServiceModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rationale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicCloudBlocker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudMigrationWave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainOSInProduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainProdServersLocations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationalizationDestiny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationalizationCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationalizationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidateToGHOSTSRV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidateToPSMutualization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixedSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalServers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionServers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionVirtualServers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionPhysicalServers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NonProductionServers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NonProductionVirtualServers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllocatedDiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedDiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEInternal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEExternal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEExternalFP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEMajorChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEMinorChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEProblems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTEServiceRequests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalStaffCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalStaffCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalStaffCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalInfrastructureCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardwareCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagedServicesCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalFPStaffCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorChangesCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinorChangesCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProblemsCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceRequestsCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfMinorChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfProblems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfServiceRequests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacklogMinorChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacklogProblems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BacklogServiceRequests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAETProblems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfMajorReleases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfITPPerYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudMigrationComplexitySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPerYearAWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostPerYearAzure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TCFKgCO2ePerYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPUTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPUTEMANUF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPUTERUN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMPUTERUNMarketBased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPERATINGMODEL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criticality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dynamism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalComplexity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessDifferentiation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DemandQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessNeedsAdequacy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredTTM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevOpsMaturity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxAcceptableDowntime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalObsolescence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maintainability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceCodeAvailability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelOfIntegration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageCustomization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeOfApplication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuppliersDependency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalOffshoreRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalOffshoreRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalOffshoreRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeIndex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITDigitalReadiness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebCollectCompleteness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelOfRobustness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OSObsolescence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VirtualizationRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiskSpaceUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionServerRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlobalRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstabilityRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintainabilityRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalObsolescenceRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolatilityRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeopleDependencyRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuppliersDependencyRisk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensePortability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudCompatibleArchitecture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataResidency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataClassification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VirtualizationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RPO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseTimeLatencyRequirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Security = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityCompliance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Integrity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confidentiality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationalizationSolutionQuality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RationalizationTCOLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CyberSecurityScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarbonIntensityRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PUERate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenewableEnergyRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostingRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostingRateRECIncluded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturingRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudRate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationLists", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "emailModel",
                columns: table => new
                {
                    To = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailModel", x => x.To);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetPasswordToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHasher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetPasswordExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "ServerLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Global = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITLandscape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScatterView = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InProduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Environment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Virtualized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfServerNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datacenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerDetailedLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OSNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OSVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OSVersionNormalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservedInstance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teeshirt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerMigrationMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerTargetInfrastructure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerMigrationPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOrphan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMutualized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixedSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfApplicationsMapped = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfCPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAMSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAllocatedDiskSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsedDiskSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsageHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerMigrationCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AWSCostPerYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AzureCostPerYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRVTCF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MANUF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RUN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RUNMarketBased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Energy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnergyPUEIncluded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebCollectCompleteness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServerOSObsolescence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRVCarbonIntensityRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRVRenewableEnergyRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRVPUERate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRVHostingRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SRVHostingRateRECIncluded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerLists_ApplicationLists_AppId",
                        column: x => x.AppId,
                        principalTable: "ApplicationLists",
                        principalColumn: "AppId");
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    C_Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                    AppId = table.Column<int>(type: "int", nullable: false),
                    C_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Application_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serverinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Portinfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.C_Id);
                   
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServerLists_AppId",
                table: "ServerLists",
                column: "AppId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "emailModel");

            migrationBuilder.DropTable(
                name: "ServerLists");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "ApplicationLists");
        }
    }
}
