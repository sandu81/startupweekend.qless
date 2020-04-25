using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartupWeek.Qless.Model;

namespace StartupWeek.Qless.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurfewPassController : ControllerBase
    {


        private readonly ILogger<CurfewPassController> _logger;

        public CurfewPassController(ILogger<CurfewPassController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CurfewPass> Get(int userId)
        {
            return new List<CurfewPass>();
        }


        [HttpPost]
        public IEnumerable<CurfewPass> Post(CurfewPassRequest request)
        {
            return new List<CurfewPass>();
        }
    }
}
