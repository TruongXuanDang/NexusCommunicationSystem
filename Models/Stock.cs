using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunicationSystem.Models
{
    public class Stock
    {
        public int Id { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Name { get; set; }
        public double PricePerUnit { get; set; }
        public int Amount { get; set; }

        public virtual RetailStore RetailStore { get; set; }
        public virtual ICollection<Stock_Billing> Stock_Billings { get; set; }
    }
}