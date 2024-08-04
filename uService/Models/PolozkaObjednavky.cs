using System.ComponentModel.DataAnnotations;

namespace uService.Models
{
    public class PolozkaObjednavky
    {

        public PolozkaObjednavky(string nazevZbozi, int pocetKusu, decimal cena)
        {
            NazevZbozi = nazevZbozi;
            PocetKusu = pocetKusu;
            Cena = cena;
            Validace();
        }

        [Key]
        public string NazevZbozi { get; set; }

        public int PocetKusu { get; set; }

        public decimal Cena { get; set; }

        public int ObjednavkaId { get; set; }

        public Objednavka Objednavka { get; set; }

        private void Validace()
        {

            if(PocetKusu <= 0)
            {
                throw new Exception($"Pro {NazevZbozi} nemuze byt pocet kusu roven nebo mensi nez nule.");
            }

            if(Cena <= 0)
            {
                throw new Exception($"Pro {NazevZbozi} nemuze byt cena rovna nebo mensi nez nule.");
            }
        }
    }
}
