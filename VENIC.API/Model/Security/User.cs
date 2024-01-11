namespace Model.Security
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Pass { get; set; }
        public int RolId { get; set; }
        public long ThirdId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
