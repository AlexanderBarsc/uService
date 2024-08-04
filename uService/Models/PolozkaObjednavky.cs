using System.ComponentModel.DataAnnotations;

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

        [Key]
        public string NazevZbozi { get; set; }

        public int PocetKusu { get; set; }

        public decimal CenaZaKus { get; set; }

        public int ObjednavkaId { get; set; }

        public Objednavka Objednavka { get; set; }

        private void Validace()
        {

            if(PocetKusu <= 0)
            {
                throw new Exception($"Pro {NazevZbozi} nemuze byt pocet kusu roven nebo mensi nez nule.");
            }

            if(CenaZaKus <= 0)
            {
                throw new Exception($"Pro {NazevZbozi} nemuze byt cena rovna nebo mensi nez nule.");
            }
        }
    }
}
