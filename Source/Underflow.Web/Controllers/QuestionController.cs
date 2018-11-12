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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Underflow.Web.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly UserManager<IdentityUser> _um;
        private readonly UnderflowService _service;

        public QuestionController(UnderflowService service, UserManager<IdentityUser> um)
        {
            _um = um;
            _service = service;
        }









    }
}
