using System.ComponentModel.DataAnnotations;

namespace uService.Models
{
    public class PolozkyObjednavky
    {
        [Key]
        public string NazevZbozi { get; set; }

        public int PocetKusu { get; set; }

        public decimal Cena { get; set; }
    }
}
