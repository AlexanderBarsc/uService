using Microsoft.AspNetCore.Mvc;
using uService.Contracts;
using uService.Models;
using uService.Services;

namespace uService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult> PosliObjednavku(ObjednavkaDto objednavkaDto)
        {
            var polozkyObjednavky = objednavkaDto.PolozkyObjednavky.Select(x => new PolozkaObjednavky(x.NazevZbozi, x.PocetKusu, x.CenaZaKus)).ToList();
            var objednavka = new Objednavka(objednavkaDto.Name, polozkyObjednavky);

            var vysledek = await _orderService.UlozObjednavku(objednavka);

            return Ok($"Byla uspesne vytvorena objednavka s ID {vysledek}");
        }

        [HttpPatch]
        public async Task<ActionResult> ZaplaceniObjednavky(PlatbaObjednavkyDto platbaObjednavkyDto)
        {
            await _orderService.ZaplaceniObjednavky(platbaObjednavkyDto);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> VypisObjednavky()
        {
            var vysledek = await _orderService.VypisObjednavky();

            return Ok(vysledek);
        }
    }
}
