using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KhachSan.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string taikhoan { set; get; }
        public string matkhau { set; get; }
        public bool rememberMe { set; get; }
    }
}