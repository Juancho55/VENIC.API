namespace Model.Inventory
{
    public class Inventory
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long Quantity { get; set; }
        public int Stock {  get; set; } 
        public DateTime CreateDate { get; set; }    
        public DateTime? LastUpdate {  get; set; }
        public bool Active { get; set; }
    }
}
