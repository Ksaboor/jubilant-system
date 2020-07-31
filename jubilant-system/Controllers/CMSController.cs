using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jubilant_system.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CMSController : ControllerBase
    {

        //GET: /<controller>/
        [HttpGet]
        public Object Get()
        {
            return new {
                primaryColor = "#F36533",
                secondaryColor = "#73645E",
                tertiaryColor = "#FFFFFF",
                quaternary = "#000000",
                primaryFont = "GSK header button font",
                secondaryFont = "GSK text, card font",
                languageType = "us-english"
            };
        }
    }
}
