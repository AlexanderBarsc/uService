using Microsoft.EntityFrameworkCore;
using uService.Contracts;
using uService.Database;
using uService.Models;
using uService.ViewModels;

namespace uService.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _dbContext;

        public OrderService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> UlozObjednavku(Objednavka objednavka)
        {

            await _dbContext.Objednavky.AddAsync(objednavka);

            await _dbContext.SaveChangesAsync();

            return objednavka.Id;
     
        }

        public async Task<IEnumerable<ObjednavkaViewModel>> VypisObjednavky()
        {
            var list = await _dbContext.Objednavky.ToListAsync();

            var objednavky = list.Select(objednavka => new ObjednavkaViewModel(
                objednavka.Id,
                objednavka.Name,
                objednavka.DatumVytvoreni,
                objednavka.StavObjednavky,
                objednavka.PolozkyObjednavky.Select(x => new PolozkaObjednavkyViewModel(x.NazevZbozi, x.PocetKusu, x.CenaZaKus)).ToList()));

            return objednavky;
        }

        public async Task ZaplaceniObjednavky(PlatbaObjednavkyDto platbaObjednavkyDto)
        {
            var objednavka = await _dbContext.Objednavky.FindAsync(platbaObjednavkyDto.CisloObjednavky);

            if(objednavka == null)
            {
                throw new Exception($"Objednavka s cislem {platbaObjednavkyDto.CisloObjednavky} nebyla nalezena.");
            }

            objednavka.StavObjednavky = platbaObjednavkyDto.BylaObjednavkaZaplacena ? StavObjednavky.Zaplacena : StavObjednavky.Zrusena;

            await _dbContext.SaveChangesAsync();

        }
    }
}
