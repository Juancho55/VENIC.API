namespace Model.Thirds
{
    public class MediaCommunication
    {
        public long Id { get; set; }
        public int MediaTypeId { get; set; }
        public long ThirdId { get; set; }
        public string? Chain {  get; set; }
        public bool Active { get; set; }
    }
}
