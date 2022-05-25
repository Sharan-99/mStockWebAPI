using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mStockWebAPI
{
    public class WatchList
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
        public string description { get; set; }
        public string price { get; set; }
    }
}
