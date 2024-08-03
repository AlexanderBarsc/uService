namespace uService.Models
{
    public class Objednavka
    {
        public Objednavka(string name, IEnumerable<PolozkyObjednavky> polozkyObjednavky)
        {
            Name = name;
            DatumVytvoreni = DateTime.Now;
            StavObjednavky = StavObjednavky.Nova;
            PolozkyObjednavky = polozkyObjednavky;


        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DatumVytvoreni { get; set; }

        public StavObjednavky StavObjednavky { get; set; }

        public IEnumerable<PolozkyObjednavky> PolozkyObjednavky { get; set; }
    }
}
