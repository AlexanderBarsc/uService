using uService.Models;

namespace uService.Contracts
{
    public class ObjednavkaDto
    { 
        public string Name { get; set; }

        public IEnumerable<PolozkaObjednavky> PolozkyObjednavky { get; set; }
    }
}
