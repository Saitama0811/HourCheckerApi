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
    public class DataController : Controller
    {
        private readonly DataAccessLayer _context;

        public DataController(DataAccessLayer context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult InsertData([FromBody]DataTable data)
        {
            _context.addUser(data);
            return Ok();
        }


        

    }
}
