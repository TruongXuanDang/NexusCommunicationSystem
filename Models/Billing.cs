using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunicationSystem.Models
{
    public class Billing
    {
        public int Id { get; set; }
        [Required]
        public string Account { get; set; }
        public float SecurityDeposit { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double AmountDue { get; set; }
        public float ChargeForReplacementDone { get; set; }
        public float Discounts { get; set; } 
        [Required]
        public string BillingsStatus { get; set; } 
        public string CreatedAt { get; set; } 
        public string UpdatedAt { get; set; } 

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<Stock_Billing> Stock_Billings { get; set; }
    }

    public enum BillingStatus
    {
        Done = 1,
        Cancel = 0,
        Deleted = -1,
    }
}