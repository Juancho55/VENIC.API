namespace Model.Thirds
{
    public class Address
    {
        public int Id { get; set; }
        public long ThirdId { get; set; }
        public int AddressTypeId { get; set; }
        public int CityId { get; set; }
        public string? PostalCode { get; set; }
        public string? Street {  get; set; }
        public string? NeigthBorth { get; set; }
        public string? AdditionalData {  get; set; }
        public bool Active { get; set; }
    }
}
