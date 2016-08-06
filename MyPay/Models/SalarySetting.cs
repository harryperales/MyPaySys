using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyPay.Models
{
    public class SalarySetting
    {
        [Key]
        public int Id { get; set; }

        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(5)]
        public string GraceTime { get; set; }           // 10m

        [Column(TypeName = "varchar")]
        [StringLength(5)]
        public string InLunchBreakTime { get; set; }    // 20m

        [Column(TypeName = "varchar")]
        [StringLength(5)]
        public string OutLunchBreakTime { get; set; }   // 1h

        public int LeaveAllowed { get; set; }           // 3 => 3 days in a month

        public int BonusStartMonth { get; set; }

        public int DiwaliBonusPercent { get; set; }
        public int PongalBonusPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal BonusIncrement { get; set; }     // +0.25%
    }
}