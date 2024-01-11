namespace Model.Log
{
    public class Log
    {
        public Guid Id {  get; set; }
        public long LogTypeId { get; set; }
        public string? JSON { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
    }
}
