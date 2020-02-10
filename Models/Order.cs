using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunicationSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string PaymentPeriod { get; set; }
        [Required]
        public OrderStatus OrderStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual RetailStore RetailStore { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

    public enum OrderStatus
    {
        Pending = 5,
        Confirmed = 4,
        DirectTransfer = 3,
        Done = 1,
        Shipping = 2,
        Cancel = 0,
        Deleted = -1,
    }
}