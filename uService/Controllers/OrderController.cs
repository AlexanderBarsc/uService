using Microsoft.AspNetCore.Mvc;
using uService.Contracts;
using uService.Database;
using uService.Models;

namespace uService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class OrderController : ControllerBase
    {

        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> PosliObjednavku(ObjednavkaDto objednavka)
        {
            _context.Objednavky.Add(objednavka);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
