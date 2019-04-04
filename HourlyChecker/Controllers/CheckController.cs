using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HourlyChecker.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HourlyChecker.Controllers
{
    [Route("api/[controller]")]
    public class CheckController : Controller
    {
        private readonly DataAccessLayer _context;

        public CheckController(DataAccessLayer context)
        {
            _context = context;
        }

        [HttpPost]
        public bool CheckTime([FromBody]DataAccessLayer.latestdatetime datetime)
        {
            var result =_context.onCheck(datetime);
            return result;
        }
    }
}
