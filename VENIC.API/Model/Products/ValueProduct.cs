namespace Model.Products
{
    public class ValueProduct
    {
        public long Id { get; set; }
        public int ValueTypeId { get; set; }
        public long ProductId { get; set; }
        public decimal Value {  get; set; }
        public bool Active { get; set; }
    }
}
