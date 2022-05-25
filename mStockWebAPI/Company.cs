using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mStockWebAPI
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string CurrentStockPrice { get; set; }

    }
}
