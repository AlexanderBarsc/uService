using System.Threading.Tasks;
using uService.Contracts;
using uService.Models;

namespace uService.Services
{
    public interface IOrderService
    {
        Task UlozObjednavku(Objednavka objednavka);

        Task VypisObjednavky(string jmenoObjednavky);
    }
}
