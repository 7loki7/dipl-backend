using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseAPI.Models;

namespace ExpenseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ExpenseDetailContext _context;

        public LoginController(ExpenseDetailContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<string>> LoginCheck(User user)
        {
            var check = _context.User.Where(x => x.Username == user.Username && x.Password == user.Password);

            if (check.Any())
            {
                return Ok("Success");
            }
            else return NotFound("Fail");
        }
    }
}
