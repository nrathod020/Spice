using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Spice.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double OrderTotalOriginal { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "Order Total")]
        public double OrderTotal { get; set; }

        [Required]
        [NotMapped]
        public DateTime PickUpDate { get; set; }
        [Display(Name ="Coupon Code")]
        public string? CouponCode { get; set; }
        public double? CouponCodeDiscount { get; set; }
        public string Status { get; set; }

        public string PaymentStatus { get; set; }
        public string Comments { get; set; }
        [Display (Name ="PickUp Name")]

        public string PickUpName { get; set; }
        [Display(Name = "Phone Number")]

        public string PhoneNo { get; set; }
        public string? TransactionId { get; set; }
        public DateTime PickUpTime { get; set; }
    }
}
