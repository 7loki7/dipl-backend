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
    [Route("api/ExpenseDetails")]
    [ApiController]
    public class ExpenseDetailsController : Controller
    {
        private readonly ExpenseDetailContext _context;

        public ExpenseDetailsController(ExpenseDetailContext context)
        {
            _context = context;
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<IEnumerable<ExpenseDetail>>> GetListByUsername(string username)
        {
            return await _context.ExpenseDetails.Where(x => x.Username == username).ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<ExpenseDetail>> PostPaymentDetail(ExpenseDetail expenseDetail)
        {
            _context.ExpenseDetails.Add(expenseDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostPaymentDetail", new { id = expenseDetail.ExpenseId }, expenseDetail);
        }

        // PUT: api/PaymentDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetail(int id, ExpenseDetail expenseDetail)
        {
            if (id != expenseDetail.ExpenseId)
            {
                return BadRequest();
            }

            _context.Entry(expenseDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/PaymentDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseDetail(int id)
        {
            var expenseDetail = await _context.ExpenseDetails.FindAsync(id);
            if (expenseDetail == null)
            {
                return NotFound();
            }

            _context.ExpenseDetails.Remove(expenseDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExpenseDetailExists(int id)
        {
            return _context.ExpenseDetails.Any(e => e.ExpenseId == id);
        }
    }
}
