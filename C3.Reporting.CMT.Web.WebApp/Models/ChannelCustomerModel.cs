using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CsvHelper.Configuration;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class ChannelCustomerModel
    {
        public int ChannelCustomerId { get; set; }

        [Required]
        public int ChannelId { get; set; }

        [Required]
        public long CustomerSid { get; set; }
    }
}