using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MyPay.Models
{
    public class EmployeeAttendance
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AttendanceDate { get; set; }

        //[Column(TypeName = "time")]
        public DateTime InTime { get; set; }

        //[Column(TypeName = "time")]
        public DateTime LunchBeginTime { get; set; }

        //[Column(TypeName = "time")]
        public DateTime LunchEndTime { get; set; }

        //[Column(TypeName = "time")]
        public DateTime OutTime { get; set; }

        public virtual Employee Employee { get; set; }
    }
}