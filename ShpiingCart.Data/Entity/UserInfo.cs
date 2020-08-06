using System;
using System.Collections.Generic;

namespace ShpiingCart.Data.Models
{
    public partial class UserInfo
    {
        public int Sno { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPwd { get; set; }
    }
}
