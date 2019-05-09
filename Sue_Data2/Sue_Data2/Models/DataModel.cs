using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Suec_Data2.Models
{
    public class DataModel
    {
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { set; get; }

        [Display(Name = "Ticket")]
        public int Ticket { set; get; }

        [Display(Name = "Response Minutes")]
        public int ResponseMinutes { set; get; }

        [Display(Name = "Ticket Total")]
        public int TicketSum { set; get; }

        [Display(Name = "Ticket Total")]
        public double AvergeTime { set; get; }
        public double Hr { set; get; }
        public double Minute { set; get; }
        public double Day { set; get; }

        public double RespositeTime { set; get; }
    }

}