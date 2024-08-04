namespace uService.Models
{
    public class PolozkaObjednavky
    {

        public PolozkaObjednavky(string nazevZbozi, int pocetKusu, decimal cenaZaKus)
        {
            NazevZbozi = nazevZbozi;
            PocetKusu = pocetKusu;
            CenaZaKus = cenaZaKus;
            Validace();
        }


        public string NazevZbozi { get; set; }

        public int PocetKusu { get; set; }

        public decimal CenaZaKus { get; set; }

        public virtual int ObjednavkaId { get; set; }

        public virtual Objednavka Objednavka { get; set; }

        private void Validace()
        {
            if(string.IsNullOrWhiteSpace(NazevZbozi))
            {
                throw new Exception("Jedno ze zadanych zbozi ma prazdny nazev.");
            }

            if(PocetKusu <= 0)
            {
                throw new Exception($"Pro zbozi {NazevZbozi} nemuze byt pocet kusu roven nebo mensi nez nule.");
            }

            if(CenaZaKus <= 0)
            {
                throw new Exception($"Pro zbozi {NazevZbozi} nemuze byt cena rovna nebo mensi nez nule.");
            }
        }
    }
}
