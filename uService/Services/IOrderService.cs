using uService.Contracts;
using uService.Models;
using uService.ViewModels;

namespace uService.Services
{
    public interface IOrderService
    {
        Task<int> UlozObjednavku(Objednavka objednavka);

        Task<IEnumerable<ObjednavkaViewModel>> VypisObjednavky();

        Task ZaplaceniObjednavky(PlatbaObjednavkyDto platbaObjednavkyDto);
    }
}
