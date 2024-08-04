using Microsoft.AspNetCore.Mvc;
using uService.Contracts;
using uService.Database;
using uService.Models;
using uService.Services;

namespace uService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class OvladacObjednavek : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OvladacObjednavek(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult> PosliObjednavku(ObjednavkaDto objednavkaDto)
        {
            var polozkyObjednavky = objednavkaDto.PolozkyObjednavky.Select(x => new PolozkaObjednavky(x.NazevZbozi, x.PocetKusu, x.CenaZaKus)).ToList();
            var objednavka = new Objednavka(objednavkaDto.Name, polozkyObjednavky);

            await _orderService.UlozObjednavku(objednavka);

            return Ok();
        }


        [HttpGet("{jmenoObjednavky}")]
        public async Task<ActionResult> VypisObjednavky(string jmenoObjednavky)
        {
            await _orderService.VypisObjednavky(jmenoObjednavky);

            return Ok();
        }
    }
}
