﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {

        [Display(Name = "Event ID")]
        public int EventId { get; set; }
        // [DisplayFormat(DataFormatString = "{0:h:mm tt}")]

        [Display(Name = "Starting Time")]
        public DateTime EventFrom { get; set; }

        [Display(Name = "Ending time")]
        public DateTime EventTo { get; set; }

        [Display(Name = "Creator")]
        public string EnteredBy { get; set; }

        [Display(Name = "Activity ID")]
        public int ActivityId { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
    }
}
