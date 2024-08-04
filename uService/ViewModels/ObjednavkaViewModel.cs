using uService.Models;

namespace uService.ViewModels
{
    public class ObjednavkaViewModel
    {
        public ObjednavkaViewModel(int id, string name, DateTime datumVytvoreni, StavObjednavky stavObjednavky, ICollection<PolozkaObjednavkyViewModel> polozkyObjednavky)
        {
            CisloObjednavky = id;
            Name = name;
            DatumVytvoreni = datumVytvoreni;
            StavObjednavky = stavObjednavky.ToString();
            PolozkyObjednavky = polozkyObjednavky;
        }
        public int CisloObjednavky { get; set; }

        public string Name { get; set; }

        public DateTime DatumVytvoreni { get; set; }

        public string StavObjednavky { get; set; }

        public virtual ICollection<PolozkaObjednavkyViewModel> PolozkyObjednavky { get; set; }
    }
}
