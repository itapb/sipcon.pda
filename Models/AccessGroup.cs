using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    public class AccessGroup
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

    }
}
