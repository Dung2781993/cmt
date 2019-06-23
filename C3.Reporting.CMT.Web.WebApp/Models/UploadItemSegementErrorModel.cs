using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C3.Reporting.CMT.Web.WebApp.Models
{
    public class UploadItemSegementErrorModel
    {
        public int ChannelId { get; set; }

        public string ItemCode { get; set; }

        public string ErrorMessage { get; set; }
    }
}