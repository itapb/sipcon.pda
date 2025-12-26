using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    public class TemporyKey
    {
        public int UserId { get; set; } = 0;
        public string Login { get; set; } = string.Empty;

    }
}
