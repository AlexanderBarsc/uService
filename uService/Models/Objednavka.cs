namespace uService.Models
{
    public class Objednavka
    {
        // Prazdny konstruktor pro EF
        public Objednavka()
        {
            
        }
        public Objednavka(string name, ICollection<PolozkaObjednavky> polozkyObjednavky)
        {
            Name = name;
            DatumVytvoreni = DateTime.Now;
            StavObjednavky = StavObjednavky.Nova;
            PolozkyObjednavky = polozkyObjednavky;

            Validace();
        }

        // O generaci ID se stará databáze
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DatumVytvoreni { get; set; }

        public StavObjednavky StavObjednavky { get; set; }

        public virtual ICollection<PolozkaObjednavky> PolozkyObjednavky { get; set; }

        private void Validace()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                throw new Exception("Jmeno zakaznika nebo firmy u objednavky nemuze byt prazdne!");
            }

            if (PolozkyObjednavky.Count == 0)
            {
                throw new Exception("Objednavka musi obsahovat aspon jednu polozku!");
            }
        }
    }
}
