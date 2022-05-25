using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mStockWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : Controller
    {
        public List<WatchList> list = new List<WatchList>();
        public List<Company> companies = new List<Company>()
        {
            new Company(){CompanyId=101,CompanyName="Wipro",Description="Wipro,IT company established on 2006",CurrentStockPrice="500" },
            new Company(){CompanyId=102,CompanyName="Hewlett Packard",Description="Most successful company",CurrentStockPrice="1000" },
            new Company(){CompanyId=103,CompanyName="Cognizant",Description="Celebrating 25years of excellence in India",CurrentStockPrice="1500" },
        };

        public List<Login> loginDetails = new List<Login>()
        { 
            new Login(){Email="sharan@gmail.com",Password="Sharan&2022!"},
            new Login(){Email="naveen@gmail.com",Password="Naveen%2021#"}
        };

        [HttpGet]
        [Route("companies")]
        public IEnumerable<Company> Companies()
        {
            return companies;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(Login login)
        {
            var loginResult = loginDetails.Where(x => x.Email == login.Email && x.Password == login.Password).FirstOrDefault();
            if (loginResult == null)
                return Content("Failed");
            else
                return Content("Success");
        }

        [HttpPost]
        [Route("watchlist")]
        public IActionResult WatchList(WatchList watchlist)
        {
            
            list.Add(watchlist);
            if(list!=null)
            {
                return Content("Added");
            }
            else
            {
                return Content("Failed");
            }
        }

        [HttpGet]
        [Route("watchlist")]
        public List<WatchList> GetWatchList()
        {
            return list;
        }
    }
}
