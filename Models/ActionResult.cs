using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    public class ActionResult
    {
        public int Value { get; set; } = 0;
        public int InsertedRows { get; set; } = 0;
        public int UpdatedRows { get; set; } = 0;
        public int LastId { get; set; } = 0;

    }
}