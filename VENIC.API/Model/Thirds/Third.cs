namespace Model.Thirds
{
    public class Third
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? FirstSurName { get; set; }
        public string? SecondSurName { get; set; }
        public string? ComercialName { get; set; }
        public int DocumentTypeId { get; set; }
        public string? DocumentNumber { get; set; }
        public int ThirdTypeId { get; set; }
        public int GenderId { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? LegalDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
