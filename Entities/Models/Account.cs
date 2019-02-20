using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("account")]
    public class Account
    {
        [Key]
        public Guid Id { get; set; }        

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "Owner is required")]
        public Guid OwnerId { get; set; }
    }
}
