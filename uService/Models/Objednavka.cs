namespace uService.Models
{
    public class Objednavka
    {
        // Prazdny konstruktor pro EF
        public Objednavka()
        {
            
        }
        public Objednavka(string name, IEnumerable<PolozkaObjednavky> polozkyObjednavky)
        {
            Name = name;
            DatumVytvoreni = DateTime.Now;
            StavObjednavky = StavObjednavky.Nova;
            PolozkyObjednavky = polozkyObjednavky;
        }

        // O generaci ID se stará databáze
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DatumVytvoreni { get; set; }

        public StavObjednavky StavObjednavky { get; set; }

        public IEnumerable<PolozkaObjednavky> PolozkyObjednavky { get; set; }
    }
}
