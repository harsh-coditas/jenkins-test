using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectAndSellSupport.Domain.ViewModels
{
    public class UserUploadError
    {
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }
    }
}
