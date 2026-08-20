using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    // ==================== REQUEST MODELS ====================

    public class StockCountDetail
    {
        [Required]
        public int? IdInventory { get; set; }

        [Required]
        public string? LocationCode { get; set; }

        [Required]
        public string? PartCode { get; set; }

        [Required]
        public int? Quantity { get; set; }
    }

    public class UnassignedPartRequest
    {
        [Required]
        public int? IdInventory { get; set; }

        [Required]
        public string? LocationCode { get; set; }

        [Required]
        public string? PartCode { get; set; }

        [Required]
        public int? Quantity { get; set; }
    }

    // ==================== RESPONSE MODELS ====================

    public class ActiveInventoryResponse
    {
        public bool HasActiveInventory { get; set; }
    }

    public class InventoryTypeOption
    {
        public int IdCountType { get; set; }
        public string VName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string AssignmentType { get; set; } = string.Empty;
        public string AssignmentName { get; set; } = string.Empty;
        public int IdInventoryCount { get; set; }
        public int HasAssignment { get; set; }
        public int IdStatus { get; set; }
        public string VDescription { get; set; } = string.Empty;
        public int IdCount { get; set; }
    }

    public class LocationValidationResponse
    {
        public int LocationId { get; set; }
        public string LocationCode { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
        public string ZoneName { get; set; } = string.Empty;
        public bool IsValid { get; set; }
        public string? Message { get; set; }
    }

    public class PartValidationResponse
    {
        public int PartId { get; set; }
        public string PartCode { get; set; } = string.Empty;
        public string LocationName { get; set; } = string.Empty;
        public string PartDescription { get; set; } = string.Empty;
        public bool IsValid { get; set; }
        public string? Message { get; set; }
    }

    public class InventoryDetailResponse
    {
        public int IdLocation { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public int IdPart { get; set; }
        public string PartCode { get; set; } = string.Empty;
        public string PartDescription { get; set; } = string.Empty;
        public int IdStatus { get; set; }
        public int IdCount { get; set; }
        public bool IsPending { get; set; }
        
    }

    public class StockCountResponse
    {
        public int? Iid { get; set; }
        public int? Iinserted { get; set; }
        public int? Iupdated { get; set; }
        public string? Message { get; set; }
    }
}