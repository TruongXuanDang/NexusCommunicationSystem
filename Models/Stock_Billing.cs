using System.ComponentModel.DataAnnotations;

namespace NexusCommunicationSystem.Models
{
    public class Stock_Billing
    {
        public int Id { get; set; }
        [Required]
        public int BillingId { get; set; }
        [Required]
        public int StockId { get; set; }
        public double Amount { get; set; }

        public virtual Billing Billing { get; set; }
        public virtual Stock Stock { get; set; }
    }
}