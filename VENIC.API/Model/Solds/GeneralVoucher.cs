namespace Model.Solds
{
    public class GeneralVoucher
    {
        public long Id { get; set; }
        public long IdThird { get; set; }
        public DateTime CreateDate { get; set; }
        public Decimal TotalSold { get; set; }
    }
}
