using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CsvHelper.Configuration;
using CsvHelper;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class UploadCustomerModel
    {
        //[CsvField(Name = "Customer SID")]
        public long CustomerSid { get; set; }
    }
}