using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntexDatabaseConnection.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrontendConnection.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FrontendController : Controller
    {
        private mummies_testContext context;

        // controller
        public FrontendController(mummies_testContext temp)
        {
            context = temp;
        }

        // GET: /<controller>/
        public IEnumerable<Frontend> Get()
        {
            var x = context.Frontends
                .OrderBy(x => x.Burialid)
                .ToArray();
            return x;
        }

        //Post method
        //public void Post(MarriottFood m)
        //{

        //}
    }
}

