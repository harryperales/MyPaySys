using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyPay.Models
{
    public class Company
    {
        public Company()
        {
            Active = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        [Index("CompanyCode", IsUnique = true)]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Index("CompanyName", IsUnique = true)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AddressLine3 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        //public byte[] Logo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string ImagePath { get; set; }

        public bool Active { get; set; }
    }
}