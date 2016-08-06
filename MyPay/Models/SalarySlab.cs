using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyPay.Models
{
    public class SalarySlab
    {
        [Key]
        public int Id { get; set; }

        [Column("Component", TypeName = "varchar")]
        [StringLength(25)]
        public string ComponentString
        {
            get { return Component.ToString(); }
            set { Component = (SalaryComponent)Enum.Parse(typeof(SalaryComponent), value); }
        }

        [NotMapped]
        public SalaryComponent Component { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(5)]
        public string Time { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
    }

    public enum SalaryComponent
    {
        LatePenalty,
        LunchBreakIncentive,
        SaturdayAllowance,
        SundayAllowance,
        SatSunAllowance,
        HolidayAllowance
    }
}