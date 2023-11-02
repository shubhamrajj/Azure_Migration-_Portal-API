
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace ctrlspec.Models
{
    public class ServerList
    {
        [Key] 
         public int? Id { get; set; }
        public string? ServerId { get; set; }
        public string? ServerLabel { get; set; }
        public string? Global { get; set; }
        public string? ITLandscape { get; set; }
        public string? ScatterView { get; set; }
        public string? Size { get; set; }
        public string? InProduction { get; set; }
        public string? Environment { get; set; }
        public string? Virtualized { get; set; }
        public string? TypeOfServer { get; set; }
        public string? TypeOfServerNormalized { get; set; }
        public string? Datacenter { get; set; }
        public string? ServerDetailedLocation { get; set; }
        public string? Country { get; set; }
        public string? OS { get; set; }
        public string? OSNormalized { get; set; }
        public string? OSVersion { get; set; }
        public string? OSVersionNormalized { get; set; }
        public string? ReservedInstance { get; set; }
        public string? Teeshirt { get; set; }
        public string? Region { get; set; }
        public string? ServerMigrationMonth { get; set; }
        public string? ServerTargetInfrastructure { get; set; }
        public string? ServerMigrationPath { get; set; }
        public string? IsOrphan { get; set; }
        public string? IsMutualized { get; set; }
        public string? FixedSize { get; set; }
        public string? NumberOfApplicationsMapped { get; set; }
        public string? NumberOfCPU { get; set; }
        public string? RAMSize { get; set; }
        public string? TotalAllocatedDiskSize { get; set; }
        public string? UsedDiskSize { get; set; }
        public string? UsageHour { get; set; }
        public string? CurrentCost { get; set; }
        public string? ServerMigrationCost { get; set; }
        public string? AWSCostPerYear { get; set; }
        public string? AzureCostPerYear { get; set; }
        public string? SRVTCF { get; set; }
        public string? MANUF { get; set; }
        public string? RUN { get; set; }
        public string? RUNMarketBased { get; set; }
        public string? Energy { get; set; }
        public string? EnergyPUEIncluded { get; set; }
        public string? WebCollectCompleteness { get; set; }
        public string? ServerOSObsolescence { get; set; }
        public string? SRVCarbonIntensityRate { get; set; }
        public string? SRVRenewableEnergyRate { get; set; }
        public string? SRVPUERate { get; set; }
        public string? SRVHostingRate { get; set; }
        public string? SRVHostingRateRECIncluded { get; set; }
        
        [ForeignKey("ApplicationLists")]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int? AppId { get; set; }

        public ApplicationList ApplicationLists { get; set; }
         [NotMapped]
        public int? RowNumber { get; set; } // New property to store the row number/order
    }
}
