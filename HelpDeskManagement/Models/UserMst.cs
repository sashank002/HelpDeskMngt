using System;
using System.Collections.Generic;

namespace HelpDeskManagement.Models
{
    public partial class UserMst
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
        public string? Contact { get; set; }
        public string? Passwrod { get; set; }
        public string? HintQue { get; set; }
        public string? HintAns { get; set; }
        public int UserTypeId { get; set; }
    }
}
