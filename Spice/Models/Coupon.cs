using MessagePack;
using MessagePack.Formatters;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Spice.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CouponType { get; set; }
        public enum ECouponType {Percent=0,Dollar=1 }

        [Required]

        public Double Discount { get; set; }

        [Required]
        public Double MinimumAmount { get; set; }

        public byte[]? Picture { get; set; }

        public bool IsActive { get; set; }
    }
}
