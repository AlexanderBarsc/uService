namespace uService.Models
{
    public class Objednavka
    {
        private int Id { get; set; }

        public string Name { get; set; }

        private DateTime DatumVytvoreni { get; set; }

        public StavObjednavky StavObjednavky { get; set; }

        public IEnumerable<PolozkyObjednavky> PolozkyObjednavky { get; set; }
    }
}
