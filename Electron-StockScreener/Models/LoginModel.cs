using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electron_StockScreener.Models
{
    public class LoginModel
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsRemember { get; set; }
    }
}
