using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    public class Action
    {     
        public int? UserId { get; set; }        
        public int? RecordId { get; set; }       
        public int? ModuleId { get; set; } 
        public string? ActionName { get; set; }
        public string? ActionComment { get; set; }
        public int RelatedId { get; set; }

    }
}
