namespace uService.ViewModels
{
    public class PolozkaObjednavkyViewModel
    {
        public PolozkaObjednavkyViewModel(string nazevZbozi, int pocetKusu, decimal cenaZaKus)
        {
            NazevZbozi = nazevZbozi;
            PocetKusu = pocetKusu;
            CenaZaKus = cenaZaKus;
        }
        public string NazevZbozi { get; set; }

        public int PocetKusu { get; set; }

        public decimal CenaZaKus { get; set; }
    }
}
