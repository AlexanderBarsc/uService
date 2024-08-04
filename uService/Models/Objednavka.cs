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
            Id = 0;
            Name = name;
            DatumVytvoreni = DateTime.Now;
            StavObjednavky = StavObjednavky.Nova;
            PolozkyObjednavky = polozkyObjednavky;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DatumVytvoreni { get; set; }

        public StavObjednavky StavObjednavky { get; set; }

        public IEnumerable<PolozkaObjednavky> PolozkyObjednavky { get; set; }
    }
}
