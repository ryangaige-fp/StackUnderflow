using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Underflow.Business;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Underflow.Web.Controllers
{


    [Produces("application/json")]
    [Authorize]
    public class QuestionController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly UnderflowService _service;

        public QuestionController(UnderflowService service, UserManager<IdentityUser> um)
        {
            _um = um;
            _service = service;
        }


        [HttpGet]
        [Route("~/api/questions")]
        public IEnumerable<dynamic> Get()
        {

            var principal = HttpContext.User.Identity as ClaimsIdentity;

            var login = principal.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            return new dynamic[]
            {
                new {Date = DateTime.Now, Text = "AI robots world we live in"},
                new {Date = DateTime.Now, Text = "Hello World"},

            };



        }






    }
}
