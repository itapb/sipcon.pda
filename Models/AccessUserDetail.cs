using System.ComponentModel.DataAnnotations;

namespace Sipcon.Mobile.WebApp.Models
{
    public class AccessUserDetail
    {
        public int UserId { get; set; } = 0;
        public int AccessGroupId { get; set; } = 0;
        public bool Assign { get; set; } = true;
        public string AccessGroup { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string UserLastName { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
    }

    public class AccessUserDetailUp
    {
        public int UserId { get; set; } = 0;
        public int AccessGroupId { get; set; } = 0;
        public bool Assign { get; set; } = true;
      
    }

}
