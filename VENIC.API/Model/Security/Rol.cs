namespace Model.Security
{
    public class Rol
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}
