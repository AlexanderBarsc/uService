namespace uService.Contracts
{
    public class ObjednavkaDto
    {
        public string Name { get; set; }

        public IEnumerable<PolozkyObjednavkyDto> PolozkyObjednavky { get; set; }
    }
}
