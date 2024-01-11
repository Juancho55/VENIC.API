namespace Model.Products
{
    public class Category
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long FatherId { get; set; }
        public bool Acive { get; set; }
    }
}
