namespace Model.Solds
{
    public class VoucherDetail
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long VoucherId { get; set; }
        public int Quantity {  get; set; } 
        public decimal SubTotalSold { get; set; }
    }
}
