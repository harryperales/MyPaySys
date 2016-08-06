using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyPay.Models
{
    public class Designation
    {
        public Designation()
        {
            Active = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        [Index("DesigCode", IsUnique = true)]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Index("DesigName", IsUnique = true)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Description { get; set; }

        public bool Active { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}