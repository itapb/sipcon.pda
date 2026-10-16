using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    public class StockCountDetail
    {
        // Id = 0 o null → botón (+)
        // Id > 0 → conteo normal
        public int? Id { get; set; }

        [Required]
        public int? IdInventory { get; set; }

        [Required]
        public string? LocationCode { get; set; }

        [Required]
        public string? PartCode { get; set; }

        [Required]
        public int? Quantity { get; set; }
    }


    public class InventoryTypeOption
    {
        public string Tipo { get; set; } = string.Empty;            // 'FISICO' / 'CICLICO'
        public int IdInventoryCount { get; set; }
        public int IdCountType { get; set; }                        // 1 = Cíclico, 2 = Físico
        public int IdStatus { get; set; }                           // 20 = preinventario, 6 = ACTIVO
        public string VDescription { get; set; } = string.Empty;
        public int TieneAsignacion { get; set; }                    // 1 = tiene, 0 = no
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
        public int IdInventoryDetail { get; set; }
        public int IdLocation { get; set; }
        public int IdPart { get; set; }
        public int? IQuantityOld { get; set; }
        public int? IQuantityNew { get; set; }
        public string? IForm { get; set; }
        public string LocationName { get; set; } = string.Empty;
        public string PartCode { get; set; } = string.Empty;
        public string PartDescription { get; set; } = string.Empty;
        public int? IdAssign { get; set; }
        public string? VAssignType { get; set; }
        public string Modo { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
    }

    public class StockCountResponse
    {
        public int? Iid { get; set; }
        public int? Iinserted { get; set; }
        public int? Iupdated { get; set; }
        public string? Message { get; set; }
    }
}