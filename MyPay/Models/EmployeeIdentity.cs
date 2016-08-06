using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPay.Models
{
    public class EmployeeIdentity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string IdentityType { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string IdentityImagePath { get; set; }

        public virtual Employee Employee { get; set; }
    }
}