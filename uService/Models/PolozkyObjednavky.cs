using System.ComponentModel.DataAnnotations;

namespace uService.Models
{
    public class PolozkyObjednavky
    {
        public PolozkyObjednavky(string nazevZbozi, int pocetKusu, int cena)
        {
            NazevZbozi = nazevZbozi;
            PocetKusu = pocetKusu;
            Cena = cena;


        }

        [Key]
        public string NazevZbozi { get; set; }

        public int PocetKusu { get; set; }

        public decimal Cena { get; set; }

        public void Validace()
        {

            if(PocetKusu <= 0)
            {
                // Error
            }

            if(Cena <= 0)
            {
                // Error
            }
        }
    }
}
