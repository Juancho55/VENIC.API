namespace Model.Products
{
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long CategoryId { get; set; }
        public decimal UnitValue { get; set; }
        public bool Active { get; set; }
    }
}
