using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NexusCommunicationSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public string FeedBack { get; set; }
        [Required]
        public AccountRole UserRole { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

    public enum AccountRole
    { 
        User = 1,
        Admin = 2,
        AccountDepartment = 3,
        EmployeeOfRetailOutlet = 4,
        TechnicalPeople = 5
    }
}