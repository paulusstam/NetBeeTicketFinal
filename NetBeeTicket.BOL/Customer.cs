using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBeeTicket.BOL
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CustomerId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PaymentRate { get; set; }
        public string PaymentMethod { get; set; }
        public string SubscriptionType { get; set; }
        public double? SubscriptionAmount { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public string SubscriptionDetails { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public  virtual Role  Role { get; set; }

    }
}
