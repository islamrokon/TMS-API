using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class TokenModel
    {
        public int id { get; set; }
        public int clientid { get; set; }
        public System.DateTime Createdat { get; set; }
        public Nullable<System.DateTime> Expireat { get; set; }
        public string tokenaccess { get; set; }

    }
}
