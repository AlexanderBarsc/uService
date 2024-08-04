using uService.Models;

namespace uService.Contracts
{
    public class FiltrObjednavek
    {
        public string JmenoZakaznika { get; set; }

        public DateTime? ObjednavkyPoDatu { get; set; }

        public StavObjednavky? StavObjednavky { get; set; }
    }
}
