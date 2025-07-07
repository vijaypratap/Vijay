namespace QueryBotWeb.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime SaleDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
