using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class PackageModel
    {
        public int packageid { get; set; }
        public string packagetype { get; set; }
        public string packagelocation { get; set; }
        public System.DateTime eventtime { get; set; }
        public string packageprice { get; set; }
    }
}
