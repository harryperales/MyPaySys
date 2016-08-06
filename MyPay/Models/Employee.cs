using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyPay.Models
{
    public class Employee
    {
        public Employee()
        {
            Active = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        [Index("EmpCode", IsUnique = true)]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? Doj { get; set; }

        public DateTime? Dob { get; set; }

        [ForeignKey("Reporting")]
        public int? ReportingId { get; set; }

        [ForeignKey("Designation")]
        public int DesignationId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        //public byte[] Photo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string ImagePath { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [Index("EmployeeContact", IsUnique = true)]
        [StringLength(50)]
        public string ContactNumber { get; set; }

        public DateTime? Dor { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string City { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Pincode { get; set; }

        [Column(TypeName = "money")]
        public decimal BasicPay { get; set; }

        [Column(TypeName = "money")]
        public decimal Hra { get; set; }

        [Column(TypeName = "money")]
        public decimal Conveyance { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string BloodGroup { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string BankName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(25)]
        public string IfscCode { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string BankAccountNumber { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }

        public bool Active { get; set; }

        public virtual Employee Reporting { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Department Department { get; set; }
        public virtual Company Company { get; set; }

        public virtual List<EmployeeIdentity> Identities { get; set; }
    }

    //public enum Designation
    //{
    //    Manager,
    //    Supervisor,
    //    Staff
    //}
}